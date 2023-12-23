namespace HashWall
{
    partial class HomePage
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
            homep_label = new Label();
            sfile_btn = new Button();
            sfolder_btn = new Button();
            button1 = new Button();
            output_label = new Label();
            helplabel = new Label();
            panel1 = new System.Windows.Forms.Panel();
            panel2 = new System.Windows.Forms.Panel();
            label1 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // homep_label
            // 
            homep_label.AutoSize = true;
            homep_label.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            homep_label.ForeColor = Color.White;
            homep_label.Location = new Point(336, 46);
            homep_label.Name = "homep_label";
            homep_label.Size = new Size(212, 32);
            homep_label.TabIndex = 0;
            homep_label.Text = "Come on, hash it.";
            // 
            // sfile_btn
            // 
            sfile_btn.FlatStyle = FlatStyle.Popup;
            sfile_btn.ForeColor = Color.White;
            sfile_btn.Image = Properties.Resources.file;
            sfile_btn.ImageAlign = ContentAlignment.MiddleLeft;
            sfile_btn.Location = new Point(146, 166);
            sfile_btn.Name = "sfile_btn";
            sfile_btn.Size = new Size(173, 58);
            sfile_btn.TabIndex = 1;
            sfile_btn.Text = "Select File";
            sfile_btn.UseVisualStyleBackColor = true;
            sfile_btn.Click += sfile_btn_Click;
            // 
            // sfolder_btn
            // 
            sfolder_btn.FlatStyle = FlatStyle.Popup;
            sfolder_btn.ForeColor = Color.White;
            sfolder_btn.Image = Properties.Resources.folder;
            sfolder_btn.ImageAlign = ContentAlignment.MiddleLeft;
            sfolder_btn.Location = new Point(606, 166);
            sfolder_btn.Name = "sfolder_btn";
            sfolder_btn.Size = new Size(173, 58);
            sfolder_btn.TabIndex = 2;
            sfolder_btn.Text = "Select Folder";
            sfolder_btn.UseVisualStyleBackColor = true;
            sfolder_btn.Click += sfolder_btn_Click;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = Color.White;
            button1.Image = Properties.Resources.go;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(364, 367);
            button1.Name = "button1";
            button1.Size = new Size(173, 58);
            button1.TabIndex = 3;
            button1.Text = "Go and Hash It!";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // output_label
            // 
            output_label.AutoSize = true;
            output_label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            output_label.ForeColor = Color.White;
            output_label.Location = new Point(167, 313);
            output_label.Name = "output_label";
            output_label.Size = new Size(0, 21);
            output_label.TabIndex = 4;
            output_label.Click += output_label_Click;
            // 
            // helplabel
            // 
            helplabel.AutoSize = true;
            helplabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            helplabel.ForeColor = Color.White;
            helplabel.Location = new Point(12, 45);
            helplabel.MaximumSize = new Size(900, 0);
            helplabel.Name = "helplabel";
            helplabel.Size = new Size(0, 21);
            helplabel.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.Controls.Add(homep_label);
            panel1.Controls.Add(sfolder_btn);
            panel1.Controls.Add(output_label);
            panel1.Controls.Add(sfile_btn);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(927, 588);
            panel1.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(helplabel);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 488);
            panel2.Name = "panel2";
            panel2.Size = new Size(927, 100);
            panel2.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 14);
            label1.Name = "label1";
            label1.Size = new Size(63, 21);
            label1.TabIndex = 6;
            label1.Text = "Helper :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(377, 62);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 7;
            label2.Text = "label2";
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(927, 588);
            ControlBox = false;
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(927, 588);
            Name = "HomePage";
            Text = "HomePage";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label homep_label;
        private Button sfile_btn;
        private Button sfolder_btn;
        private Button button1;
        private Label output_label;
        private Label helplabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Label label1;
        private Label label2;
    }
}