using System.Windows.Forms;

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

        private void sfile_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Dosya Seç";
            openFileDialog.Filter = "Tüm Dosyalar (*.*)|*.*";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.ShowDialog(this);
            safeSelectedFileName = openFileDialog.SafeFileName;
            selectedFileName = openFileDialog.FileName;
            output_label.Text = "Selected File: " + safeSelectedFileName;
            helplabel.Text = "You selected this file: " + safeSelectedFileName + " Now, you can hash or encrypt it.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel2.Controls.Clear();
 

            HashPage hashpage = new HashPage();
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
            FolderBrowserDialog openFolderDialog= new FolderBrowserDialog();
            openFolderDialog.ShowDialog(this);
            selectedFileName = openFolderDialog.SelectedPath;
            output_label.Text = "Selected Folder: " + selectedFileName;
            helplabel.Text = "You have selected this folder: " + selectedFileName + " When you operate with this folder, the operation will be applied to all files in the folder. ";
        }
    }
}
