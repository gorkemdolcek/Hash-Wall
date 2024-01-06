namespace HashWall
{
    partial class RecentHashesPage
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
            listBox1 = new ListBox();
            fileNameLabel = new Label();
            hashTypeLabel = new Label();
            hashValueLabel = new Label();
            hashDateLabel = new Label();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(90, 84);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(532, 229);
            listBox1.TabIndex = 3;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // fileNameLabel
            // 
            fileNameLabel.AutoSize = true;
            fileNameLabel.Font = new Font("Arial Rounded MT Bold", 12F);
            fileNameLabel.ForeColor = Color.White;
            fileNameLabel.Location = new Point(90, 342);
            fileNameLabel.Name = "fileNameLabel";
            fileNameLabel.Size = new Size(91, 18);
            fileNameLabel.TabIndex = 4;
            fileNameLabel.Text = "File Name:";
            // 
            // hashTypeLabel
            // 
            hashTypeLabel.AutoSize = true;
            hashTypeLabel.Font = new Font("Arial Rounded MT Bold", 12F);
            hashTypeLabel.ForeColor = Color.White;
            hashTypeLabel.Location = new Point(90, 376);
            hashTypeLabel.Name = "hashTypeLabel";
            hashTypeLabel.Size = new Size(97, 18);
            hashTypeLabel.TabIndex = 5;
            hashTypeLabel.Text = "Hash Type:";
            // 
            // hashValueLabel
            // 
            hashValueLabel.AutoSize = true;
            hashValueLabel.Font = new Font("Arial Rounded MT Bold", 12F);
            hashValueLabel.ForeColor = Color.White;
            hashValueLabel.Location = new Point(90, 413);
            hashValueLabel.Name = "hashValueLabel";
            hashValueLabel.Size = new Size(103, 18);
            hashValueLabel.TabIndex = 6;
            hashValueLabel.Text = "Hash Value:";
            // 
            // hashDateLabel
            // 
            hashDateLabel.AutoSize = true;
            hashDateLabel.Font = new Font("Arial Rounded MT Bold", 12F);
            hashDateLabel.ForeColor = Color.White;
            hashDateLabel.Location = new Point(90, 451);
            hashDateLabel.Name = "hashDateLabel";
            hashDateLabel.Size = new Size(96, 18);
            hashDateLabel.TabIndex = 7;
            hashDateLabel.Text = "Hash Date:";
            // 
            // RecentHashesPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(746, 588);
            ControlBox = false;
            Controls.Add(hashDateLabel);
            Controls.Add(hashValueLabel);
            Controls.Add(hashTypeLabel);
            Controls.Add(fileNameLabel);
            Controls.Add(listBox1);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(746, 588);
            Name = "RecentHashesPage";
            Text = "RecentHashesPage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Label fileNameLabel;
        private Label hashTypeLabel;
        private Label hashValueLabel;
        private Label hashDateLabel;
    }
}