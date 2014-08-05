using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;

namespace MassFileRenamer
{
    public partial class Form1 : Form
    {
        public List<FileObject> objects = new List<FileObject>();

        public Form1()
        {
            InitializeComponent();
        }

        private void selectFilesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                foreach (string item in openFileDialog1.FileNames)
                {
                    if (objects.Where(x => x.OldFilePath.ToLower() == item.ToLower()).FirstOrDefault() == null) //don't include duplicate files
                    {
                        FileObject fileToAdd = new FileObject();
                        fileToAdd.OldFilePath = item;
                        fileToAdd.OldFileName = Path.GetFileName(item);
                        fileToAdd.Status = "Pending...";

                        objects.Add(fileToAdd);
                    }
                }

                this.dataGridView1.Rows.Clear();
                foreach (FileObject item in objects) this.dataGridView1.Rows.Add(item.OldFileName, item.NewFileName, item.Status);
                NewFileName_TextChanged(null, null);

                this.SaveButton.Enabled = true;
            }
        }

        private void clearFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to empty the list?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.dataGridView1.Rows.Clear();
                objects.Clear();
            }
        }

        private void NewFileName_TextChanged(object sender, EventArgs e)
        {
            int count = 0;
            int PadDigitCount = objects.Count.ToString().Length;

            foreach (DataGridViewRow item in this.dataGridView1.Rows)
            {
                objects[count].NewFileName = this.NewFileName.Text + (count+1).ToString().PadLeft(PadDigitCount, '0') + Path.GetExtension(objects[count].OldFileName);
                item.Cells[1].Value = objects[count].NewFileName;
                count++;
            }
        }

        private void NewFileName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && Path.GetInvalidFileNameChars().Contains(e.KeyChar)) e.Handled = true;
        }

        private void RenameExistingCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (this.RenameExistingCheckBox.Checked == true)
            {
                this.SavePanel.Visible = false;
                this.SaveButton.Enabled = true;
            }
            else
            {
                this.SavePanel.Visible = true;
                this.SaveButton.Enabled = this.SaveToPath.Text == "" ? false : true;
            }
        }

        private void SaveToButton_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.SaveToPath.Text = folderBrowserDialog1.SelectedPath;
                this.SaveButton.Enabled = true;
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            this.SaveButton.Enabled = false;
            int count = 0;
            foreach (FileObject item in objects)
            {
                try
                {
                    if (this.RenameExistingCheckBox.Checked == true) File.Move(item.OldFilePath, Path.GetDirectoryName(item.OldFilePath) + "\\" + item.NewFileName);
                    else File.Copy(item.OldFilePath, this.SaveToPath.Text + "\\" + item.NewFileName);
                    this.dataGridView1.Rows[count].Cells[2].Style.BackColor = Color.LightGreen;
                    this.dataGridView1.Rows[count].Cells[2].Value = "Success!";
                }
                catch (Exception ex)
                {
                    this.dataGridView1.Rows[count].Cells[2].Style.BackColor = Color.Pink;
                    this.dataGridView1.Rows[count].Cells[2].Value = "Error! " + ex.Message;
                }
                count++;
            }
        }
    }

    public class FileObject
    {
        public string OldFilePath { get; set; }
        public string OldFileName { get; set; }
        public string NewFileName { get; set; }
        public string Status { get; set; }
    }
}
