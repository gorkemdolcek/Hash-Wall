namespace HashWall
{
    partial class ToolsPage
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
            label1 = new Label();
            recenthases_btn = new Button();
            RSAstorage_btn = new Button();
            texthashing_btn = new Button();
            panel1 = new System.Windows.Forms.Panel();
            panel2 = new System.Windows.Forms.Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(136, 32);
            label1.TabIndex = 1;
            label1.Text = "Tools Page";
            // 
            // recenthases_btn
            // 
            recenthases_btn.FlatStyle = FlatStyle.Popup;
            recenthases_btn.ForeColor = Color.White;
            recenthases_btn.Image = Properties.Resources.recent;
            recenthases_btn.ImageAlign = ContentAlignment.MiddleLeft;
            recenthases_btn.Location = new Point(3, 172);
            recenthases_btn.Name = "recenthases_btn";
            recenthases_btn.Size = new Size(170, 39);
            recenthases_btn.TabIndex = 2;
            recenthases_btn.Text = "Recent Hashes";
            recenthases_btn.UseVisualStyleBackColor = true;
            recenthases_btn.Click += recenthases_btn_Click;
            // 
            // RSAstorage_btn
            // 
            RSAstorage_btn.FlatStyle = FlatStyle.Popup;
            RSAstorage_btn.ForeColor = Color.White;
            RSAstorage_btn.Image = Properties.Resources.server;
            RSAstorage_btn.ImageAlign = ContentAlignment.MiddleLeft;
            RSAstorage_btn.Location = new Point(3, 127);
            RSAstorage_btn.Name = "RSAstorage_btn";
            RSAstorage_btn.Size = new Size(170, 39);
            RSAstorage_btn.TabIndex = 3;
            RSAstorage_btn.Text = "RSA Key Storage";
            RSAstorage_btn.UseVisualStyleBackColor = true;
            RSAstorage_btn.Click += RSAstorage_btn_Click;
            // 
            // texthashing_btn
            // 
            texthashing_btn.FlatStyle = FlatStyle.Popup;
            texthashing_btn.ForeColor = Color.White;
            texthashing_btn.Image = Properties.Resources.note;
            texthashing_btn.ImageAlign = ContentAlignment.MiddleLeft;
            texthashing_btn.Location = new Point(3, 82);
            texthashing_btn.Name = "texthashing_btn";
            texthashing_btn.Size = new Size(170, 39);
            texthashing_btn.TabIndex = 4;
            texthashing_btn.Text = "Text Hashing";
            texthashing_btn.UseVisualStyleBackColor = true;
            texthashing_btn.Click += texthashing_btn_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(texthashing_btn);
            panel1.Controls.Add(recenthases_btn);
            panel1.Controls.Add(RSAstorage_btn);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(176, 588);
            panel1.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(182, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(746, 588);
            panel2.TabIndex = 6;
            // 
            // ToolsPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(928, 588);
            ControlBox = false;
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(928, 588);
            Name = "ToolsPage";
            Text = "ToolsPage";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button recenthases_btn;
        private Button RSAstorage_btn;
        private Button texthashing_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}