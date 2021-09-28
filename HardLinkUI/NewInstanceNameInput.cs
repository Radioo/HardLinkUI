using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static HardLinkUI.Global;

namespace HardLinkUI
{
    public partial class NewInstanceNameInput : Form
    {
        public string newInstanceName = "";
        public string newInstancePath = "";
        public bool copy = true;
        public NewInstanceNameInput()
        {
            InitializeComponent();
            newInstanceName = "";
            newInstancePath = "";
            copy = true;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (IsValidFileName(textBox1.Text) == true && textBox2Location.Text != "")
            {
                newInstanceName = textBox1.Text;
                newInstancePath = textBox2Location.Text;
                if (radioButton1Copy.Checked == true)
                {
                    copy = true;
                }
                else if (radioButton2Move.Checked == true)
                {
                    copy = false;
                }
                DirectoryInfo dir = new(newInstancePath);
                DataTable data = new("Data");
                data.Columns.Add("File");
                data.Columns.Add("FilePath");
                data.Columns.Add("MD5");
                int newfiles = 0;
                int alreadyexists = 0;
                var search = dir.GetFiles("", SearchOption.AllDirectories);
                progressBar1.Maximum = search.Length;
                progressBar1.Step = 1;
                foreach (var file in search)
                {
                    string checksum = GetMD5Checksum(file.FullName);
                    data.Rows.Add(file.Name, file.Directory.FullName.Replace(newInstancePath, ""), checksum+file.Extension);
                    if (File.Exists(dbDir + @"\" + checksum+file.Extension) == false)
                    {
                        if (copy == true)
                        {
                            File.Copy(file.FullName, dbDir + @"\" + checksum + file.Extension);
                        }
                        else
                        {
                            File.Move(file.FullName, dbDir + @"\" + checksum + file.Extension);
                        }
                        newfiles++;
                    }
                    else
                    {
                        alreadyexists++;
                    }
                    progressBar1.PerformStep();
                }
                data.WriteXml(xmlDir + @"\" + newInstanceName + ".xml", XmlWriteMode.WriteSchema);
                MessageBox.Show($"Done, {newfiles} new files added, {alreadyexists} files already exist.");
                progressBar1.Value = 0;
            }
            else if (IsValidFileName(textBox1.Text) == false)
            {               
                MessageBox.Show("Invalid instance name");
            }
            this.Close();
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        private bool IsValidFileName(string expression)
        {
            string sPattern = @"^(?!^(PRN|AUX|CLOCK\$|NUL|CON|COM\d|LPT\d|\..*)(\..+)?$)[^\x00-\x1f\\?*:\"";|/]+$";
            return (Regex.IsMatch(expression, sPattern, RegexOptions.CultureInvariant));
        }

        private void NewInstanceNameInput_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                textBox2Location.Text = folderBrowserDialog1.SelectedPath;
                DirectoryInfo dir = new(folderBrowserDialog1.SelectedPath);
                label2FilesFound.Text = dir.EnumerateFiles("", SearchOption.AllDirectories).Count() + " files found";
            }
        }
        public static string GetMD5Checksum(string filename)
        {
            using var md5 = MD5.Create();
            using var stream = File.OpenRead(filename);
            var hash = md5.ComputeHash(stream);
            return BitConverter.ToString(hash).Replace("-", "");
        }
    }
}
