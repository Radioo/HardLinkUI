using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static HardLinkUI.Global;

namespace HardLinkUI
{
    public partial class MainApp : Form
    {
        public MainApp()
        {
            InitializeComponent();
            InitializeApp();
            LoadXmlList();
            GetDBSize();
            
        }
        internal void InitializeApp()
        {
            if (Directory.Exists(dbDir) == false) { Directory.CreateDirectory(dbDir); }
            if (Directory.Exists(xmlDir) == false) { Directory.CreateDirectory(xmlDir); }

        }
        internal void NewInstance()
        {
            NewInstanceNameInput newinstform = new();
            newinstform.ShowDialog();
            newinstform.Dispose();
            LoadXmlList();
        }

        private void addInstanceButton_Click_1(object sender, EventArgs e)
        {
            NewInstance();
            LoadXmlList();
            GetDBSize();
        }
        public void LoadXmlList()
        {
            DataTable xmlList = new("XmlList");
            xmlList.Columns.Add("Filename");
            xmlList.Columns.Add("Entries");
            DirectoryInfo xmldir = new(xmlDir);
            foreach (var file in xmldir.GetFiles())
            {
                DataTable tempload = new();
                tempload.ReadXml(file.FullName);
                xmlList.Rows.Add(file.Name, tempload.Rows.Count);
            }
            dataGridView1.DataSource = xmlList;
            if (dataGridView1.RowCount == 0)
            {
                buttonCopyFiles.Enabled = false;
                hardLinkButton.Enabled = false;
            }
            else
            {
                buttonCopyFiles.Enabled = true;
                hardLinkButton.Enabled = true;
            }
            
        }

        private void hardLinkButton_Click(object sender, EventArgs e)
        {
            string selXml = dataGridView1.CurrentRow.Cells["Filename"].Value.ToString();
            var entriesVal = dataGridView1.CurrentRow.Cells["Entries"].Value.ToString();
            int entries = Convert.ToInt32(entriesVal);
            progressBar1.Maximum = entries;
            progressBar1.Step = 1;
            var result = MessageBox.Show($"Creating hard links from {selXml}\n" +
                $"Proceed to selecting target directory?", "Make hard links", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                var folderresult = folderBrowserMakeHardLink.ShowDialog();
                if (folderresult == DialogResult.OK)
                {
                    string target = folderBrowserMakeHardLink.SelectedPath;
                    DataTable xml = new();
                    xml.ReadXml(xmlDir + @"\" + selXml);
                    var uniqueDirs = (from row in xml.AsEnumerable() select row.Field<string>("FilePath")).Distinct();
                    foreach (var dir in uniqueDirs)
                    {
                        if (dir != "")
                        {
                            Directory.CreateDirectory(target + dir);
                        }
                    }
                    foreach (var row in xml.AsEnumerable())
                    {
                        string sourcelink = dbDir + @"\" + row.Field<string>("MD5");
                        string targetlink = target + row.Field<string>("FilePath") + @"\" + row.Field<string>("File");
                        CreateHardLink(targetlink, sourcelink, IntPtr.Zero);
                        progressBar1.PerformStep();
                    }
                    MessageBox.Show("Done!");
                    progressBar1.Value = 0;
                }
            }
            
        }

        [DllImport("Kernel32.dll", CharSet = CharSet.Unicode)]
        static extern bool CreateHardLink(
        string lpFileName,
        string lpExistingFileName,
        IntPtr lpSecurityAttributes
        );

        private void buttonShowUnused_Click_1(object sender, EventArgs e)
        {
            DirectoryInfo _dbDir = new(dbDir);
            DirectoryInfo _xmlDir = new(xmlDir);
            HashSet<string> hashes = new();
            foreach (var file in _dbDir.EnumerateFiles())
            {
                hashes.Add(file.Name);
            }
            foreach (var file in _xmlDir.EnumerateFiles())
            {
                DataTable dt = new();
                dt.ReadXml(file.FullName);
                foreach (var row in dt.AsEnumerable())
                {
                    hashes.Remove(row.Field<string>("MD5"));
                }
            }
            if (hashes.Count != 0)
            {
                var result = MessageBox.Show($"{hashes.Count} unused files found. Delete?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                progressBar1.Maximum = hashes.Count;
                progressBar1.Step = 1;
                if (result == DialogResult.Yes)
                {
                    foreach (var file in hashes)
                    {
                        File.Delete(dbDir + @"\" + file);
                        progressBar1.PerformStep();
                    }
                }
                MessageBox.Show("Done");
                progressBar1.Value = 0;
                GetDBSize();
            }
            else
            {
                MessageBox.Show("No unused files found.");
            }
        }

        private void buttonCopyFiles_Click(object sender, EventArgs e)
        {
            string selXml = dataGridView1.CurrentRow.Cells["Filename"].Value.ToString();
            var entriesVal = dataGridView1.CurrentRow.Cells["Entries"].Value.ToString();
            int entries = Convert.ToInt32(entriesVal);
            progressBar1.Maximum = entries;
            progressBar1.Step = 1;
            var result = MessageBox.Show($"Copying files from {selXml}.\n" +
                $"Proceed to selecting copy destination?", "Copy files", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                var folderresult = folderBrowserCopyFiles.ShowDialog();
                if (folderresult == DialogResult.OK)
                {
                    DataTable dt = new();
                    dt.ReadXml(xmlDir + @"\" + selXml);
                    foreach (var row in dt.AsEnumerable())
                    {
                        if (row.Field<string>("FilePath") != "")
                        {
                            Directory.CreateDirectory(folderBrowserCopyFiles.SelectedPath + row.Field<string>("FilePath"));
                        }
                        File.Copy(dbDir + @"\" + row.Field<string>("MD5"), folderBrowserCopyFiles.SelectedPath + row.Field<string>("FilePath") + @"\" + row.Field<string>("File"));
                        progressBar1.PerformStep();
                    }
                    MessageBox.Show("Done");
                    progressBar1.Value = 0;
                }
            }
        }
        public void GetDBSize()
        {
            DirectoryInfo dir = new(dbDir);
            long dbsize = 0;
            foreach (var file in dir.EnumerateFiles())
            {
                dbsize = dbsize + file.Length;
            }
            buttonShowUnused.Text = $"Delete unused DB files\n" +
                $"(DB size: {Math.Round(((dbsize/1024f)/1024f)/1024f, 2)} GB)";
        }
    }
}