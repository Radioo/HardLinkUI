
namespace HardLinkUI
{
    partial class NewInstanceNameInput
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.goBackButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.dataImportLabel = new System.Windows.Forms.Label();
            this.textBox2Location = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.radioButton1Copy = new System.Windows.Forms.RadioButton();
            this.radioButton2Move = new System.Windows.Forms.RadioButton();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label2FilesFound = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Instance name:";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(12, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(383, 23);
            this.textBox1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.goBackButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.okButton, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 177);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(383, 33);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // goBackButton
            // 
            this.goBackButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.goBackButton.Location = new System.Drawing.Point(3, 3);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(185, 27);
            this.goBackButton.TabIndex = 0;
            this.goBackButton.Text = "Go back";
            this.goBackButton.UseVisualStyleBackColor = true;
            this.goBackButton.Click += new System.EventHandler(this.goBackButton_Click);
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.Location = new System.Drawing.Point(194, 3);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(186, 27);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "Confirm";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // dataImportLabel
            // 
            this.dataImportLabel.AutoSize = true;
            this.dataImportLabel.Location = new System.Drawing.Point(12, 53);
            this.dataImportLabel.Name = "dataImportLabel";
            this.dataImportLabel.Size = new System.Drawing.Size(198, 15);
            this.dataImportLabel.TabIndex = 3;
            this.dataImportLabel.Text = "Location of the data to be imported:";
            // 
            // textBox2Location
            // 
            this.textBox2Location.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2Location.Location = new System.Drawing.Point(12, 71);
            this.textBox2Location.Name = "textBox2Location";
            this.textBox2Location.Size = new System.Drawing.Size(276, 23);
            this.textBox2Location.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(294, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Browse...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioButton1Copy
            // 
            this.radioButton1Copy.AutoSize = true;
            this.radioButton1Copy.Checked = true;
            this.radioButton1Copy.Location = new System.Drawing.Point(12, 100);
            this.radioButton1Copy.Name = "radioButton1Copy";
            this.radioButton1Copy.Size = new System.Drawing.Size(77, 19);
            this.radioButton1Copy.TabIndex = 6;
            this.radioButton1Copy.TabStop = true;
            this.radioButton1Copy.Text = "Copy files";
            this.radioButton1Copy.UseVisualStyleBackColor = true;
            // 
            // radioButton2Move
            // 
            this.radioButton2Move.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton2Move.AutoSize = true;
            this.radioButton2Move.Location = new System.Drawing.Point(316, 100);
            this.radioButton2Move.Name = "radioButton2Move";
            this.radioButton2Move.Size = new System.Drawing.Size(79, 19);
            this.radioButton2Move.TabIndex = 7;
            this.radioButton2Move.Text = "Move files";
            this.radioButton2Move.UseVisualStyleBackColor = true;
            // 
            // label2FilesFound
            // 
            this.label2FilesFound.AutoSize = true;
            this.label2FilesFound.Location = new System.Drawing.Point(12, 122);
            this.label2FilesFound.Name = "label2FilesFound";
            this.label2FilesFound.Size = new System.Drawing.Size(0, 15);
            this.label2FilesFound.TabIndex = 8;
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(12, 140);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(383, 31);
            this.progressBar1.TabIndex = 9;
            // 
            // NewInstanceNameInput
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.goBackButton;
            this.ClientSize = new System.Drawing.Size(407, 222);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label2FilesFound);
            this.Controls.Add(this.radioButton2Move);
            this.Controls.Add(this.radioButton1Copy);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2Location);
            this.Controls.Add(this.dataImportLabel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "NewInstanceNameInput";
            this.Text = "New instance";
            this.Load += new System.EventHandler(this.NewInstanceNameInput_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button goBackButton;
        private System.Windows.Forms.Button okButton;
        internal System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label dataImportLabel;
        private System.Windows.Forms.TextBox textBox2Location;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioButton1Copy;
        private System.Windows.Forms.RadioButton radioButton2Move;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label2FilesFound;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}