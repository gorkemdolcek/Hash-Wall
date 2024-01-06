using System.Windows.Forms;
using Org.BouncyCastle.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace HashWall
{
    public partial class HomePage : Form

    {



        private string selectedFileName = "";
        private string safeSelectedFileName = "";
        private string safePublicKeySelectedFileName = "";
        private string PublicKeyselectedFileName = "";
        private string safePrivateKeySelectedFileName = "";
        private string PrivateKeyselectedFileName = "";
        private OpenFileDialog rsaPrivateKeyOpenFileDialog = new OpenFileDialog();
        private OpenFileDialog rsaPublicKeyOpenFileDialog = new OpenFileDialog();
        DialogResult result;
        DialogResult result2;
        private string sonuc;



        public HomePage()
        {
            InitializeComponent();
        }

        public void sfile_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "Dosya Seç";
            openFileDialog1.Filter = "Tüm Dosyalar (*.*)|*.*";
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.ShowDialog(this);
            safeSelectedFileName = openFileDialog1.SafeFileName;
            selectedFileName = openFileDialog1.FileName;
            label1.Text = "Selected File: " + safeSelectedFileName;
            helplabel.Text = "You selected this file: " + safeSelectedFileName + " Now, you can hash or encrypt it.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel2.Controls.Clear();

            HashPage hashpage = new HashPage(selectedFileName);
            hashpage.TopLevel = false;
            hashpage.AutoScroll = true;
            panel1.Controls.Add(hashpage);
            hashpage.Visible = true;
            hashpage.Dock = DockStyle.Fill;
            hashpage.FormBorderStyle = FormBorderStyle.None;
            hashpage.Show();
        }

        private void output_label_Click(object sender, EventArgs e)
        {
                
         
        }

        private void sfolder_btn_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1 = new FolderBrowserDialog();
            folderBrowserDialog1.ShowDialog(this);
            selectedFileName = folderBrowserDialog1.SelectedPath;
            label1.Text = "Selected Folder: " + selectedFileName;
            helplabel.Text = "You have selected this folder: " + selectedFileName + " When you operate with this folder, the operation will be applied to all files in the folder. ";
        }
    }
}
