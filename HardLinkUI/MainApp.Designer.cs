
namespace HardLinkUI
{
    partial class MainApp
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.addInstanceButton = new System.Windows.Forms.Button();
            this.hardLinkButton = new System.Windows.Forms.Button();
            this.folderBrowserMakeHardLink = new System.Windows.Forms.FolderBrowserDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonShowUnused = new System.Windows.Forms.Button();
            this.buttonCopyFiles = new System.Windows.Forms.Button();
            this.folderBrowserCopyFiles = new System.Windows.Forms.FolderBrowserDialog();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(12, 406);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(772, 25);
            this.progressBar1.TabIndex = 0;
            // 
            // addInstanceButton
            // 
            this.addInstanceButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addInstanceButton.Location = new System.Drawing.Point(3, 3);
            this.addInstanceButton.Name = "addInstanceButton";
            this.addInstanceButton.Size = new System.Drawing.Size(187, 55);
            this.addInstanceButton.TabIndex = 0;
            this.addInstanceButton.Text = "Add instance";
            this.addInstanceButton.UseVisualStyleBackColor = true;
            this.addInstanceButton.Click += new System.EventHandler(this.addInstanceButton_Click_1);
            // 
            // hardLinkButton
            // 
            this.hardLinkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hardLinkButton.Location = new System.Drawing.Point(196, 3);
            this.hardLinkButton.Name = "hardLinkButton";
            this.hardLinkButton.Size = new System.Drawing.Size(187, 55);
            this.hardLinkButton.TabIndex = 1;
            this.hardLinkButton.Text = "Make hard links";
            this.hardLinkButton.UseVisualStyleBackColor = true;
            this.hardLinkButton.Click += new System.EventHandler(this.hardLinkButton_Click);
            // 
            // folderBrowserMakeHardLink
            // 
            this.folderBrowserMakeHardLink.Description = "Select hard link target folder";
            this.folderBrowserMakeHardLink.UseDescriptionForTitle = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(12, 94);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowCellErrors = false;
            this.dataGridView1.ShowCellToolTips = false;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.ShowRowErrors = false;
            this.dataGridView1.Size = new System.Drawing.Size(772, 306);
            this.dataGridView1.TabIndex = 2;
            // 
            // buttonShowUnused
            // 
            this.buttonShowUnused.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonShowUnused.Location = new System.Drawing.Point(389, 3);
            this.buttonShowUnused.Name = "buttonShowUnused";
            this.buttonShowUnused.Size = new System.Drawing.Size(187, 55);
            this.buttonShowUnused.TabIndex = 3;
            this.buttonShowUnused.Text = "Delete unused DB files";
            this.buttonShowUnused.UseVisualStyleBackColor = true;
            this.buttonShowUnused.Click += new System.EventHandler(this.buttonShowUnused_Click_1);
            // 
            // buttonCopyFiles
            // 
            this.buttonCopyFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCopyFiles.Location = new System.Drawing.Point(582, 3);
            this.buttonCopyFiles.Name = "buttonCopyFiles";
            this.buttonCopyFiles.Size = new System.Drawing.Size(187, 55);
            this.buttonCopyFiles.TabIndex = 4;
            this.buttonCopyFiles.Text = "Copy files";
            this.buttonCopyFiles.UseVisualStyleBackColor = true;
            this.buttonCopyFiles.Click += new System.EventHandler(this.buttonCopyFiles_Click);
            // 
            // folderBrowserCopyFiles
            // 
            this.folderBrowserCopyFiles.Description = "Select copy destination";
            this.folderBrowserCopyFiles.UseDescriptionForTitle = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.addInstanceButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonCopyFiles, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.hardLinkButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonShowUnused, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 27);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(772, 61);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Loading...";
            // 
            // MainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 443);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.progressBar1);
            this.Name = "MainApp";
            this.Text = "HardLinkUI";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button addInstanceButton;
        private System.Windows.Forms.Button hardLinkButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserMakeHardLink;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonShowUnused;
        private System.Windows.Forms.Button buttonCopyFiles;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserCopyFiles;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
    }
}

