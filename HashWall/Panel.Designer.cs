namespace HashWall
{
    partial class Panel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Panel));
            menu_panel = new System.Windows.Forms.Panel();
            logo_pictureBox = new PictureBox();
            exit_btn = new Button();
            contributors_btn = new Button();
            tools_btn = new Button();
            home_btn = new Button();
            hashwall_label = new Label();
            page_panel = new System.Windows.Forms.Panel();
            menu_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo_pictureBox).BeginInit();
            SuspendLayout();
            // 
            // menu_panel
            // 
            menu_panel.Controls.Add(logo_pictureBox);
            menu_panel.Controls.Add(exit_btn);
            menu_panel.Controls.Add(contributors_btn);
            menu_panel.Controls.Add(tools_btn);
            menu_panel.Controls.Add(home_btn);
            menu_panel.Controls.Add(hashwall_label);
            menu_panel.Dock = DockStyle.Left;
            menu_panel.Location = new Point(0, 0);
            menu_panel.Name = "menu_panel";
            menu_panel.Size = new Size(160, 588);
            menu_panel.TabIndex = 0;
            menu_panel.Paint += menu_panel_Paint;
            // 
            // logo_pictureBox
            // 
            logo_pictureBox.Image = Properties.Resources.hashwall_logo;
            logo_pictureBox.Location = new Point(12, 13);
            logo_pictureBox.Name = "logo_pictureBox";
            logo_pictureBox.Size = new Size(135, 115);
            logo_pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            logo_pictureBox.TabIndex = 0;
            logo_pictureBox.TabStop = false;
            logo_pictureBox.Click += logo_pictureBox_Click;
            // 
            // exit_btn
            // 
            exit_btn.FlatStyle = FlatStyle.Popup;
            exit_btn.ForeColor = Color.White;
            exit_btn.Location = new Point(25, 514);
            exit_btn.Name = "exit_btn";
            exit_btn.Size = new Size(103, 35);
            exit_btn.TabIndex = 3;
            exit_btn.Text = "Exit";
            exit_btn.UseVisualStyleBackColor = true;
            exit_btn.Click += exit_btn_Click;
            // 
            // contributors_btn
            // 
            contributors_btn.FlatStyle = FlatStyle.Popup;
            contributors_btn.ForeColor = Color.White;
            contributors_btn.Location = new Point(25, 301);
            contributors_btn.Name = "contributors_btn";
            contributors_btn.Size = new Size(103, 35);
            contributors_btn.TabIndex = 2;
            contributors_btn.Text = "Contributors";
            contributors_btn.UseVisualStyleBackColor = true;
            contributors_btn.Click += contributors_btn_Click;
            // 
            // tools_btn
            // 
            tools_btn.FlatStyle = FlatStyle.Popup;
            tools_btn.ForeColor = Color.White;
            tools_btn.Location = new Point(25, 260);
            tools_btn.Name = "tools_btn";
            tools_btn.Size = new Size(103, 35);
            tools_btn.TabIndex = 1;
            tools_btn.Text = "Tools";
            tools_btn.UseVisualStyleBackColor = true;
            tools_btn.Click += tools_btn_Click;
            // 
            // home_btn
            // 
            home_btn.FlatStyle = FlatStyle.Popup;
            home_btn.ForeColor = Color.White;
            home_btn.Location = new Point(25, 219);
            home_btn.Name = "home_btn";
            home_btn.Size = new Size(103, 35);
            home_btn.TabIndex = 0;
            home_btn.Text = "Home";
            home_btn.UseVisualStyleBackColor = true;
            home_btn.Click += home_btn_Click;
            // 
            // hashwall_label
            // 
            hashwall_label.AutoSize = true;
            hashwall_label.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            hashwall_label.ForeColor = Color.White;
            hashwall_label.Location = new Point(25, 144);
            hashwall_label.Name = "hashwall_label";
            hashwall_label.Size = new Size(103, 24);
            hashwall_label.TabIndex = 0;
            hashwall_label.Text = "HashWall";
            // 
            // page_panel
            // 
            page_panel.Dock = DockStyle.Fill;
            page_panel.Location = new Point(160, 0);
            page_panel.MinimumSize = new Size(900, 550);
            page_panel.Name = "page_panel";
            page_panel.Size = new Size(927, 588);
            page_panel.TabIndex = 2;
            page_panel.Paint += page_panel_Paint;
            // 
            // Panel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.Black;
            ClientSize = new Size(1087, 588);
            Controls.Add(page_panel);
            Controls.Add(menu_panel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Panel";
            Text = "HashWall";
            menu_panel.ResumeLayout(false);
            menu_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logo_pictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel menu_panel;
        private System.Windows.Forms.Panel page_panel;
        private PictureBox logo_pictureBox;
        private Label hashwall_label;
        private Button exit_btn;
        private Button contributors_btn;
        private Button tools_btn;
        private Button home_btn;
    }
}
