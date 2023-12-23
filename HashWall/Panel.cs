namespace HashWall
{
    public partial class Panel : Form
    {
        public Panel()
        {
            InitializeComponent();
        }

        private void logo_pictureBox_Click(object sender, EventArgs e)
        {

        }

        private void home_btn_Click(object sender, EventArgs e)
        {
            page_panel.Controls.Clear();

            HomePage homepage = new HomePage();
            homepage.TopLevel = false;
            homepage.AutoScroll = true;
            page_panel.Controls.Add(homepage);
            homepage.Show();
        }

        private void tools_btn_Click(object sender, EventArgs e)
        {
            page_panel.Controls.Clear();

            ToolsPage toolspage = new ToolsPage();
            toolspage.TopLevel = false;
            toolspage.AutoScroll = true;
            page_panel.Controls.Add(toolspage);
            toolspage.Show();
        }

        private void contributors_btn_Click(object sender, EventArgs e)
        {
            page_panel.Controls.Clear();

            ContributorsPage contributorspage = new ContributorsPage();
            contributorspage.TopLevel = false;
            contributorspage.AutoScroll = true;
            page_panel.Controls.Add(contributorspage);
            contributorspage.Show();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void page_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menu_panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
