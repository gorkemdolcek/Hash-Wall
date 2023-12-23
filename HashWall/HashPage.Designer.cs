namespace HashWall
{
    partial class HashPage
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
            textpanel = new System.Windows.Forms.Panel();
            label5 = new Label();
            hashmain_panel = new System.Windows.Forms.Panel();
            en_dec_panel = new System.Windows.Forms.Panel();
            button7 = new Button();
            privateKeyLabel = new Label();
            button9 = new Button();
            label3 = new Label();
            label1 = new Label();
            button5 = new Button();
            publicKeyLabel = new Label();
            button4 = new Button();
            button1 = new Button();
            storageCheckbox = new CheckBox();
            keySizeValue = new ComboBox();
            label2 = new Label();
            en_dec_label = new Label();
            hashit_panel = new System.Windows.Forms.Panel();
            richTextBox = new RichTextBox();
            allhashes_btn = new Button();
            hashIt_btn = new Button();
            hashComboBox = new ComboBox();
            hashit_label = new Label();
            panel1 = new System.Windows.Forms.Panel();
            helpLabel = new Label();
            textpanel.SuspendLayout();
            hashmain_panel.SuspendLayout();
            en_dec_panel.SuspendLayout();
            hashit_panel.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // textpanel
            // 
            textpanel.Controls.Add(label5);
            textpanel.Dock = DockStyle.Top;
            textpanel.Location = new Point(0, 0);
            textpanel.Name = "textpanel";
            textpanel.Size = new Size(927, 89);
            textpanel.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoEllipsis = true;
            label5.Font = new Font("Tw Cen MT", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(3, 0);
            label5.Name = "label5";
            label5.Size = new Size(924, 89);
            label5.TabIndex = 6;
            label5.Text = "\r\nNo file selected yet!\r\nYou can select your file on \"File\" tab.\r\n\r\n";
            label5.TextAlign = ContentAlignment.BottomCenter;
            // 
            // hashmain_panel
            // 
            hashmain_panel.Controls.Add(en_dec_panel);
            hashmain_panel.Controls.Add(hashit_panel);
            hashmain_panel.Dock = DockStyle.Fill;
            hashmain_panel.Location = new Point(0, 89);
            hashmain_panel.Name = "hashmain_panel";
            hashmain_panel.Size = new Size(927, 399);
            hashmain_panel.TabIndex = 2;
            hashmain_panel.Paint += hashmain_panel_Paint;
            // 
            // en_dec_panel
            // 
            en_dec_panel.Controls.Add(button7);
            en_dec_panel.Controls.Add(privateKeyLabel);
            en_dec_panel.Controls.Add(button9);
            en_dec_panel.Controls.Add(label3);
            en_dec_panel.Controls.Add(label1);
            en_dec_panel.Controls.Add(button5);
            en_dec_panel.Controls.Add(publicKeyLabel);
            en_dec_panel.Controls.Add(button4);
            en_dec_panel.Controls.Add(button1);
            en_dec_panel.Controls.Add(storageCheckbox);
            en_dec_panel.Controls.Add(keySizeValue);
            en_dec_panel.Controls.Add(label2);
            en_dec_panel.Controls.Add(en_dec_label);
            en_dec_panel.Dock = DockStyle.Right;
            en_dec_panel.Location = new Point(426, 0);
            en_dec_panel.Name = "en_dec_panel";
            en_dec_panel.Size = new Size(501, 399);
            en_dec_panel.TabIndex = 1;
            // 
            // button7
            // 
            button7.Location = new Point(58, 350);
            button7.Margin = new Padding(3, 2, 3, 2);
            button7.Name = "button7";
            button7.Size = new Size(393, 35);
            button7.TabIndex = 34;
            button7.Text = "Decrypt and Save!";
            button7.UseVisualStyleBackColor = true;
            // 
            // privateKeyLabel
            // 
            privateKeyLabel.AutoSize = true;
            privateKeyLabel.ForeColor = Color.White;
            privateKeyLabel.Location = new Point(252, 319);
            privateKeyLabel.Name = "privateKeyLabel";
            privateKeyLabel.Size = new Size(98, 15);
            privateKeyLabel.TabIndex = 33;
            privateKeyLabel.Text = "Nothing Selected";
            // 
            // button9
            // 
            button9.Location = new Point(27, 312);
            button9.Margin = new Padding(3, 2, 3, 2);
            button9.Name = "button9";
            button9.Size = new Size(219, 28);
            button9.TabIndex = 32;
            button9.Text = "Select Private Key!";
            button9.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft PhagsPa", 14.25F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(207, 285);
            label3.Name = "label3";
            label3.Size = new Size(88, 25);
            label3.TabIndex = 31;
            label3.Text = "Decrypt!";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft PhagsPa", 14.25F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(207, 151);
            label1.Name = "label1";
            label1.Size = new Size(86, 25);
            label1.TabIndex = 30;
            label1.Text = "Encrypt!";
            // 
            // button5
            // 
            button5.Location = new Point(58, 232);
            button5.Margin = new Padding(3, 2, 3, 2);
            button5.Name = "button5";
            button5.Size = new Size(393, 35);
            button5.TabIndex = 29;
            button5.Text = "Encrypt and Save!";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // publicKeyLabel
            // 
            publicKeyLabel.AutoSize = true;
            publicKeyLabel.ForeColor = Color.White;
            publicKeyLabel.Location = new Point(252, 192);
            publicKeyLabel.Name = "publicKeyLabel";
            publicKeyLabel.Size = new Size(98, 15);
            publicKeyLabel.TabIndex = 28;
            publicKeyLabel.Text = "Nothing Selected";
            // 
            // button4
            // 
            button4.Location = new Point(27, 185);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(219, 28);
            button4.TabIndex = 27;
            button4.Text = "Select Public Key!";
            button4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(58, 102);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(393, 36);
            button1.TabIndex = 24;
            button1.Text = "Generate Pair! (Public - Private)";
            button1.UseVisualStyleBackColor = true;
            // 
            // storageCheckbox
            // 
            storageCheckbox.AutoSize = true;
            storageCheckbox.ForeColor = Color.White;
            storageCheckbox.Location = new Point(37, 78);
            storageCheckbox.Name = "storageCheckbox";
            storageCheckbox.Size = new Size(107, 19);
            storageCheckbox.TabIndex = 23;
            storageCheckbox.Text = "Save to Storage";
            storageCheckbox.UseVisualStyleBackColor = true;
            // 
            // keySizeValue
            // 
            keySizeValue.AutoCompleteMode = AutoCompleteMode.Suggest;
            keySizeValue.BackColor = Color.WhiteSmoke;
            keySizeValue.FormattingEnabled = true;
            keySizeValue.Items.AddRange(new object[] { "4096", "2048", "512", "1024" });
            keySizeValue.Location = new Point(112, 50);
            keySizeValue.Margin = new Padding(3, 2, 3, 2);
            keySizeValue.Name = "keySizeValue";
            keySizeValue.Size = new Size(377, 23);
            keySizeValue.TabIndex = 22;
            keySizeValue.Text = "2048";
            keySizeValue.SelectedIndexChanged += keySizeValue_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(37, 50);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 21;
            label2.Text = "Key Size:";
            // 
            // en_dec_label
            // 
            en_dec_label.Dock = DockStyle.Top;
            en_dec_label.Font = new Font("Tw Cen MT", 18F, FontStyle.Bold);
            en_dec_label.ForeColor = Color.White;
            en_dec_label.Location = new Point(0, 0);
            en_dec_label.Name = "en_dec_label";
            en_dec_label.Size = new Size(501, 48);
            en_dec_label.TabIndex = 2;
            en_dec_label.Text = "ENCRYPT - DECRYPT";
            en_dec_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // hashit_panel
            // 
            hashit_panel.Controls.Add(richTextBox);
            hashit_panel.Controls.Add(allhashes_btn);
            hashit_panel.Controls.Add(hashIt_btn);
            hashit_panel.Controls.Add(hashComboBox);
            hashit_panel.Controls.Add(hashit_label);
            hashit_panel.Dock = DockStyle.Left;
            hashit_panel.Location = new Point(0, 0);
            hashit_panel.Name = "hashit_panel";
            hashit_panel.Size = new Size(420, 399);
            hashit_panel.TabIndex = 0;
            // 
            // richTextBox
            // 
            richTextBox.Location = new Point(16, 198);
            richTextBox.Margin = new Padding(3, 2, 3, 2);
            richTextBox.Name = "richTextBox";
            richTextBox.ReadOnly = true;
            richTextBox.Size = new Size(389, 187);
            richTextBox.TabIndex = 7;
            richTextBox.Text = "";
            // 
            // allhashes_btn
            // 
            allhashes_btn.Location = new Point(12, 127);
            allhashes_btn.Margin = new Padding(3, 2, 3, 2);
            allhashes_btn.Name = "allhashes_btn";
            allhashes_btn.Size = new Size(393, 34);
            allhashes_btn.TabIndex = 6;
            allhashes_btn.Text = "Generate All Hashes!";
            allhashes_btn.UseVisualStyleBackColor = true;
            // 
            // hashIt_btn
            // 
            hashIt_btn.Location = new Point(12, 87);
            hashIt_btn.Margin = new Padding(3, 2, 3, 2);
            hashIt_btn.Name = "hashIt_btn";
            hashIt_btn.Size = new Size(393, 36);
            hashIt_btn.TabIndex = 5;
            hashIt_btn.Text = "Hash It!";
            hashIt_btn.UseVisualStyleBackColor = true;
            // 
            // hashComboBox
            // 
            hashComboBox.BackColor = Color.WhiteSmoke;
            hashComboBox.Dock = DockStyle.Fill;
            hashComboBox.FormattingEnabled = true;
            hashComboBox.Items.AddRange(new object[] { "MD2", "MD4", "MD5", "SHA-1", "SHA-224", "SHA-256", "SHA-384", "SHA-512", "Whirlpool", "RIPEMD128", "RIPEMD160", "RIPEMD256", "RIPEMD320" });
            hashComboBox.Location = new Point(0, 48);
            hashComboBox.Margin = new Padding(3, 2, 3, 2);
            hashComboBox.Name = "hashComboBox";
            hashComboBox.Size = new Size(420, 23);
            hashComboBox.TabIndex = 4;
            hashComboBox.Text = "MD5";
            // 
            // hashit_label
            // 
            hashit_label.Dock = DockStyle.Top;
            hashit_label.Font = new Font("Tw Cen MT", 18F, FontStyle.Bold);
            hashit_label.ForeColor = Color.White;
            hashit_label.Location = new Point(0, 0);
            hashit_label.Name = "hashit_label";
            hashit_label.Size = new Size(420, 48);
            hashit_label.TabIndex = 1;
            hashit_label.Text = "HASH IT";
            hashit_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(helpLabel);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 488);
            panel1.Name = "panel1";
            panel1.Size = new Size(927, 100);
            panel1.TabIndex = 1;
            // 
            // helpLabel
            // 
            helpLabel.AutoEllipsis = true;
            helpLabel.Font = new Font("Tw Cen MT", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            helpLabel.ForeColor = Color.White;
            helpLabel.Location = new Point(0, 3);
            helpLabel.Name = "helpLabel";
            helpLabel.Size = new Size(924, 97);
            helpLabel.TabIndex = 5;
            helpLabel.Text = "DreamLock will help you with hashing, logging, and encryption. When you are using the app, this text will assist you. Enjoy!\r\n\r\nDon't forget to check the special menu!";
            // 
            // HashPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(927, 588);
            ControlBox = false;
            Controls.Add(hashmain_panel);
            Controls.Add(panel1);
            Controls.Add(textpanel);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(927, 588);
            Name = "HashPage";
            Text = "HashPage";
            textpanel.ResumeLayout(false);
            hashmain_panel.ResumeLayout(false);
            en_dec_panel.ResumeLayout(false);
            en_dec_panel.PerformLayout();
            hashit_panel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel textpanel;
        private System.Windows.Forms.Panel hashmain_panel;
        private System.Windows.Forms.Panel en_dec_panel;
        private System.Windows.Forms.Panel hashit_panel;
        private RichTextBox richTextBox;
        private Button allhashes_btn;
        private Button hashIt_btn;
        private ComboBox hashComboBox;
        private Label hashit_label;
        private Label en_dec_label;
        private CheckBox storageCheckbox;
        private ComboBox keySizeValue;
        private Label label2;
        private Button button1;
        private Label label1;
        private Button button5;
        private Label publicKeyLabel;
        private Button button4;
        private Label label3;
        private Button button7;
        private Label privateKeyLabel;
        private Button button9;
        private System.Windows.Forms.Panel panel1;
        private Label helpLabel;
        private Label label5;
    }
}