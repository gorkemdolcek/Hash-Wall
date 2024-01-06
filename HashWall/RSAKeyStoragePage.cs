using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HashWall
{
    public partial class RSAKeyStoragePage : Form
    {
        public RSAKeyStoragePage()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string keySize = "2048";
            int keysize2 = Int32.Parse(keySize);
            var rsa = new RSACryptoServiceProvider(keysize2);
            string buffer = rsa.ToXmlString(false);
            string buffer2 = rsa.ToXmlString(true);

            SaveFileDialog savePublicDialog = new SaveFileDialog();
            savePublicDialog.Filter = "C# RSA Public Key (*.xml)|*.xml|All Files (*.*)|*.*";
            if (savePublicDialog.ShowDialog() == DialogResult.OK)
            {
                string publicKeyPath = savePublicDialog.FileName;
                StreamWriter Kayit = new StreamWriter(savePublicDialog.FileName);
                Kayit.WriteLine(buffer);
                Kayit.Close();
                rsaKeyStorageManager csvManager2 = new rsaKeyStorageManager();
                csvManager2.checkdbFile();
                csvManager2.WriteToCsv("Public", Path.GetFileName(savePublicDialog.FileName), savePublicDialog.FileName, DateTime.Now);


            }
            SaveFileDialog savePrivateDialog = new SaveFileDialog();
            savePrivateDialog.Filter = "C# RSA Private Key (*.xml)|*.xml|All Files (*.*)|*.*";
            if (savePrivateDialog.ShowDialog() == DialogResult.OK)
            {
                string privateKeyPath = savePrivateDialog.FileName;
                StreamWriter Kayit = new StreamWriter(savePrivateDialog.FileName);
                Kayit.WriteLine(buffer2);
                Kayit.Close();
                rsaKeyStorageManager csvManager2 = new rsaKeyStorageManager();
                csvManager2.checkdbFile();
                csvManager2.WriteToCsv("Private", Path.GetFileName(savePrivateDialog.FileName), savePrivateDialog.FileName, DateTime.Now);
            }
            keyList.Items.Clear();

            rsaKeyStorageManager csvManager3 = new rsaKeyStorageManager();
            List<FileRecord2> readRecords2 = csvManager3.ReadFromCsv();

            foreach (var record in readRecords2)
            {
                ListViewItem item2 = new ListViewItem(record.keyType);
                item2.SubItems.Add(record.keyName);
                item2.SubItems.Add(record.keySavedLocation);
                item2.SubItems.Add(record.keyCreationDate);
                keyList.Items.Add(item2);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rsaKeyStorageManager csvManager3 = new rsaKeyStorageManager();
            List<FileRecord2> readRecords = csvManager3.ReadFromCsv();
            foreach (var record in readRecords)
            {
                try
                {
                    if (keyList.SelectedItems[0].SubItems[1].Text == record.keyName)
                    {
                        csvManager3.DeleteRowByKeyname(keyList.SelectedItems[0].SubItems[1].Text);

                    }
                }
                catch { MessageBox.Show("Invalid"); }
            }
            keyList.Items.Clear();
            List<FileRecord2> readRecords2 = csvManager3.ReadFromCsv();

            foreach (var record in readRecords2)
            {
                ListViewItem item2 = new ListViewItem(record.keyType);
                item2.SubItems.Add(record.keyName);
                item2.SubItems.Add(record.keySavedLocation);
                item2.SubItems.Add(record.keyCreationDate);
                keyList.Items.Add(item2);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string location = keyList.SelectedItems[0].SubItems[2].Text;
            string fileContent;
            try
            {
                using (StreamReader sr = new StreamReader(location))
                {
                    fileContent = sr.ReadToEnd();
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "C# RSA Key (*.xml)|*.xml|All Files (*.*)|*.*";
                    saveFileDialog.Title = "Dosyayı Kaydet";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string savePath = saveFileDialog.FileName;
                        using (StreamWriter sw = new StreamWriter(savePath))
                        {
                            sw.Write(fileContent);
                        }

                        MessageBox.Show("Success.");
                    }
                }
            }
            catch
            {
                MessageBox.Show("This key is deleted or corrupted.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string location = Path.GetDirectoryName(keyList.SelectedItems[0].SubItems[2].Text);
                Process.Start(location);
            }
            catch
            {
                MessageBox.Show("Acces Denied. You should start with admin rights for this.");
            }
        }
    }
}
