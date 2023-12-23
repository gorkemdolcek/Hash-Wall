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
    public partial class ToolsPage : Form
    {
        public ToolsPage()
        {
            InitializeComponent();
        }

        private void recenthases_btn_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();

            RecentHashesPage recenthashes = new RecentHashesPage();
            recenthashes.TopLevel = false;
            panel2.Controls.Add(recenthashes);
            recenthashes.Show();

        }

        private void RSAstorage_btn_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();

            RSAKeyStoragePage rsastorage = new RSAKeyStoragePage();
            rsastorage.TopLevel = false;
            panel2.Controls.Add(rsastorage);
            rsastorage.Show();

        }

        private void texthashing_btn_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();

            TextHashingPage texthashing = new TextHashingPage();
            texthashing.TopLevel = false;
            panel2.Controls.Add(texthashing);
            texthashing.Show();
        }
    }
}
