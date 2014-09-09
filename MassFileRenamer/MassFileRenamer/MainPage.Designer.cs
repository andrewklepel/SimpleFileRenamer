namespace MassFileRenamer
{
    partial class MainPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectFilesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clearFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.FileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NewNamePreview = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullFilePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaveToPath = new System.Windows.Forms.TextBox();
            this.SaveToButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NewFileName = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.StartAt = new System.Windows.Forms.Panel();
            this.SavePanel = new System.Windows.Forms.Panel();
            this.RenameExistingCheckBox = new System.Windows.Forms.CheckBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.StartNumber = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.StartAt.SuspendLayout();
            this.SavePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StartNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(599, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectFilesToolStripMenuItem1,
            this.clearFilesToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // selectFilesToolStripMenuItem1
            // 
            this.selectFilesToolStripMenuItem1.Name = "selectFilesToolStripMenuItem1";
            this.selectFilesToolStripMenuItem1.Size = new System.Drawing.Size(140, 22);
            this.selectFilesToolStripMenuItem1.Text = "Select Files...";
            this.selectFilesToolStripMenuItem1.Click += new System.EventHandler(this.selectFilesToolStripMenuItem1_Click);
            // 
            // clearFilesToolStripMenuItem
            // 
            this.clearFilesToolStripMenuItem.Name = "clearFilesToolStripMenuItem";
            this.clearFilesToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.clearFilesToolStripMenuItem.Text = "Clear Files...";
            this.clearFilesToolStripMenuItem.Click += new System.EventHandler(this.clearFilesToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Multiselect = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FileName,
            this.NewNamePreview,
            this.Status,
            this.FullFilePath});
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(0, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(461, 234);
            this.dataGridView1.TabIndex = 1;
            // 
            // FileName
            // 
            this.FileName.HeaderText = "File Name";
            this.FileName.Name = "FileName";
            this.FileName.ReadOnly = true;
            this.FileName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.FileName.Width = 170;
            // 
            // NewNamePreview
            // 
            this.NewNamePreview.HeaderText = "New Name (Preview)";
            this.NewNamePreview.Name = "NewNamePreview";
            this.NewNamePreview.Width = 170;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            // 
            // FullFilePath
            // 
            this.FullFilePath.HeaderText = "Full File Path";
            this.FullFilePath.Name = "FullFilePath";
            this.FullFilePath.Visible = false;
            // 
            // SaveToPath
            // 
            this.SaveToPath.Location = new System.Drawing.Point(6, 16);
            this.SaveToPath.Name = "SaveToPath";
            this.SaveToPath.ReadOnly = true;
            this.SaveToPath.Size = new System.Drawing.Size(118, 20);
            this.SaveToPath.TabIndex = 2;
            // 
            // SaveToButton
            // 
            this.SaveToButton.Location = new System.Drawing.Point(50, 42);
            this.SaveToButton.Name = "SaveToButton";
            this.SaveToButton.Size = new System.Drawing.Size(74, 23);
            this.SaveToButton.TabIndex = 3;
            this.SaveToButton.Text = "Browse...";
            this.SaveToButton.UseVisualStyleBackColor = true;
            this.SaveToButton.Click += new System.EventHandler(this.SaveToButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Save to...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "New file name";
            // 
            // NewFileName
            // 
            this.NewFileName.Location = new System.Drawing.Point(6, 16);
            this.NewFileName.Name = "NewFileName";
            this.NewFileName.Size = new System.Drawing.Size(118, 20);
            this.NewFileName.TabIndex = 6;
            this.NewFileName.Text = "renamed_";
            this.NewFileName.TextChanged += new System.EventHandler(this.NewFileName_TextChanged);
            this.NewFileName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NewFileName_KeyPress);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(6, 198);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(118, 28);
            this.SaveButton.TabIndex = 10;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // StartAt
            // 
            this.StartAt.Controls.Add(this.label3);
            this.StartAt.Controls.Add(this.StartNumber);
            this.StartAt.Controls.Add(this.SavePanel);
            this.StartAt.Controls.Add(this.RenameExistingCheckBox);
            this.StartAt.Controls.Add(this.SaveButton);
            this.StartAt.Controls.Add(this.label2);
            this.StartAt.Controls.Add(this.NewFileName);
            this.StartAt.Dock = System.Windows.Forms.DockStyle.Right;
            this.StartAt.Location = new System.Drawing.Point(467, 24);
            this.StartAt.Name = "StartAt";
            this.StartAt.Size = new System.Drawing.Size(132, 238);
            this.StartAt.TabIndex = 11;
            // 
            // SavePanel
            // 
            this.SavePanel.Controls.Add(this.SaveToButton);
            this.SavePanel.Controls.Add(this.SaveToPath);
            this.SavePanel.Controls.Add(this.label1);
            this.SavePanel.Location = new System.Drawing.Point(0, 120);
            this.SavePanel.Name = "SavePanel";
            this.SavePanel.Size = new System.Drawing.Size(132, 72);
            this.SavePanel.TabIndex = 12;
            this.SavePanel.Visible = false;
            // 
            // RenameExistingCheckBox
            // 
            this.RenameExistingCheckBox.AutoSize = true;
            this.RenameExistingCheckBox.Checked = true;
            this.RenameExistingCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.RenameExistingCheckBox.Location = new System.Drawing.Point(7, 97);
            this.RenameExistingCheckBox.Name = "RenameExistingCheckBox";
            this.RenameExistingCheckBox.Size = new System.Drawing.Size(125, 17);
            this.RenameExistingCheckBox.TabIndex = 11;
            this.RenameExistingCheckBox.Text = "Rename existing files";
            this.RenameExistingCheckBox.UseVisualStyleBackColor = true;
            this.RenameExistingCheckBox.CheckedChanged += new System.EventHandler(this.RenameExistingCheckBox_CheckedChanged);
            // 
            // StartNumber
            // 
            this.StartNumber.Location = new System.Drawing.Point(66, 43);
            this.StartNumber.Maximum = new decimal(new int[] {
            1744830463,
            -1364693708,
            12368714,
            0});
            this.StartNumber.Name = "StartNumber";
            this.StartNumber.Size = new System.Drawing.Size(54, 20);
            this.StartNumber.TabIndex = 13;
            this.StartNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.StartNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.StartNumber.ValueChanged += new System.EventHandler(this.StartNumber_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Start at:";
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 262);
            this.Controls.Add(this.StartAt);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(615, 300);
            this.Name = "MainPage";
            this.Text = "Mass File Renamer";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.StartAt.ResumeLayout(false);
            this.StartAt.PerformLayout();
            this.SavePanel.ResumeLayout(false);
            this.SavePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StartNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox SaveToPath;
        private System.Windows.Forms.Button SaveToButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NewFileName;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Panel StartAt;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.CheckBox RenameExistingCheckBox;
        private System.Windows.Forms.Panel SavePanel;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectFilesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clearFilesToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn NewNamePreview;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullFilePath;
        private System.Windows.Forms.NumericUpDown StartNumber;
        private System.Windows.Forms.Label label3;
    }
}

