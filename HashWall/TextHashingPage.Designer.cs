namespace HashWall
{
    partial class TextHashingPage
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
            hashInput = new TextBox();
            hashComboBox = new ComboBox();
            button1 = new Button();
            hashTextResult1 = new TextBox();
            SuspendLayout();
            // 
            // hashInput
            // 
            hashInput.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            hashInput.Location = new Point(96, 53);
            hashInput.Multiline = true;
            hashInput.Name = "hashInput";
            hashInput.Size = new Size(585, 159);
            hashInput.TabIndex = 6;
            // 
            // hashComboBox
            // 
            hashComboBox.BackColor = Color.WhiteSmoke;
            hashComboBox.FormattingEnabled = true;
            hashComboBox.Items.AddRange(new object[] { "MD2", "MD4", "MD5", "SHA-1", "SHA-224", "SHA-256", "SHA-384", "SHA-512", "Whirlpool", "RIPEMD128", "RIPEMD160", "RIPEMD256", "RIPEMD320" });
            hashComboBox.Location = new Point(279, 238);
            hashComboBox.Margin = new Padding(3, 2, 3, 2);
            hashComboBox.Name = "hashComboBox";
            hashComboBox.Size = new Size(217, 23);
            hashComboBox.TabIndex = 7;
            hashComboBox.Text = "MD5";
            // 
            // button1
            // 
            button1.Location = new Point(279, 283);
            button1.Name = "button1";
            button1.Size = new Size(217, 40);
            button1.TabIndex = 8;
            button1.Text = "Hash It!";
            button1.UseVisualStyleBackColor = true;
            // 
            // hashTextResult1
            // 
            hashTextResult1.BackColor = Color.Black;
            hashTextResult1.BorderStyle = BorderStyle.None;
            hashTextResult1.Font = new Font("Arial Rounded MT Bold", 11.25F);
            hashTextResult1.ForeColor = Color.White;
            hashTextResult1.Location = new Point(96, 364);
            hashTextResult1.Multiline = true;
            hashTextResult1.Name = "hashTextResult1";
            hashTextResult1.ReadOnly = true;
            hashTextResult1.Size = new Size(585, 134);
            hashTextResult1.TabIndex = 9;
            hashTextResult1.TabStop = false;
            hashTextResult1.Text = "Result:\r\n\r\nHash Type:\r\n\r\n";
            // 
            // TextHashingPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 588);
            ControlBox = false;
            Controls.Add(hashTextResult1);
            Controls.Add(button1);
            Controls.Add(hashComboBox);
            Controls.Add(hashInput);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(746, 588);
            Name = "TextHashingPage";
            Text = "TextHashingPage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox hashInput;
        private ComboBox hashComboBox;
        private Button button1;
        private TextBox hashTextResult1;
    }
}