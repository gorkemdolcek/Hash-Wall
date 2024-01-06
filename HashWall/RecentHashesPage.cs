using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HashWall
{
    public partial class RecentHashesPage : Form
    {
        public RecentHashesPage()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = listBox1.GetItemText(listBox1.SelectedItem);
            hashLogClass csvManager = new hashLogClass();
            List<FileRecord> readRecords = csvManager.ReadFromCsv();

            foreach (var record in readRecords)
            {
                if (record.Hash == selectedItem)
                {
                    fileNameLabel.Text = "File Name: " + record.FileName;
                    hashTypeLabel.Text = "Hash Type: " + record.HashType;
                    hashValueLabel.Text = "Hash Value: " + record.Hash;
                    hashDateLabel.Text = "Hash Date: " + record.DateTime;
                }
            }
        }
    }
}
