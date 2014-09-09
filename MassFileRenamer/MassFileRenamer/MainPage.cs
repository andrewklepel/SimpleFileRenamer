using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace MassFileRenamer
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void selectFilesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = string.Empty;
            DialogResult result = openFileDialog1.ShowDialog();
            
            if (result == DialogResult.OK)
            {
                foreach (string item in openFileDialog1.FileNames)
                {
                    //check if file path is already in the table
                    bool alreadyExists = false;
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                        if (row.Cells["FullFilePath"].Value.ToString().ToLower() == item.ToLower())
                            alreadyExists = true;
                    if (alreadyExists == false)
                        this.dataGridView1.Rows.Add(Path.GetFileName(item), "tempNewName", "Pending...", item);
                }
                NewFileName_TextChanged(null, null);
                this.SaveButton.Enabled = true;
            }
        }

        private void clearFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to empty the list?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                this.dataGridView1.Rows.Clear();
        }

        private void NewFileName_TextChanged(object sender, EventArgs e)
        {
            decimal count = Convert.ToDecimal(this.StartNumber.Value);
            int PadDigitCount = (dataGridView1.Rows.Count + count - 1).ToString().Length;

            foreach (DataGridViewRow item in this.dataGridView1.Rows)
            {
                item.Cells["NewNamePreview"].Value = this.NewFileName.Text + count.ToString().PadLeft(PadDigitCount, '0') + Path.GetExtension(item.Cells["FileName"].Value.ToString());
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

        private void StartNumber_ValueChanged(object sender, EventArgs e)
        {
            NewFileName_TextChanged(null, null);
        }
        
        private void SaveButton_Click(object sender, EventArgs e)
        {
            Thread backgroundWork = new Thread(new ThreadStart(RenameFiles));
            backgroundWork.Start();
        }

        private void RenameFiles()
        {
            foreach (DataGridViewRow item in this.dataGridView1.Rows)
            {
                try
                {
                    //'move' the file to the same directory, while renaming the file
                    if (this.RenameExistingCheckBox.Checked == true)
                    {
                        File.Move(item.Cells["FullFilePath"].Value.ToString(), Path.GetDirectoryName(item.Cells["FullFilePath"].Value.ToString()) + "\\" + item.Cells["NewNamePreview"].Value.ToString());
                        //update file path info
                        item.Cells["FullFilePath"].Value = Path.GetDirectoryName(item.Cells["FullFilePath"].Value.ToString()) + "\\" + item.Cells["NewNamePreview"].Value.ToString();
                        item.Cells["FileName"].Value = item.Cells["NewNamePreview"].Value;
                    }
                    else
                    {
                        File.Copy(item.Cells["FullFilePath"].Value.ToString(), this.SaveToPath.Text + "\\" + item.Cells["NewNamePreview"].Value.ToString());
                        //update file path info
                        item.Cells["FullFilePath"].Value = this.SaveToPath.Text + "\\" + item.Cells["NewNamePreview"].Value.ToString();
                        item.Cells["FileName"].Value = item.Cells["NewNamePreview"].Value;
                    }
                    item.Cells["Status"].Style.BackColor = Color.LightGreen;
                    item.Cells["Status"].Value = "Success!";
                }
                catch (Exception ex)
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        item.Cells["Status"].Style.BackColor = Color.Pink;
                        item.Cells["Status"].Value = "Error! " + ex.Message;
                    });
                }
            }
        }
    }
}
