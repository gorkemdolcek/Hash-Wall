namespace HashWall
{
    partial class RSAKeyStoragePage
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
            keyList = new ListView();
            keyTypeHeader = new ColumnHeader();
            keyNameHeader = new ColumnHeader();
            keySavedLocationHeader = new ColumnHeader();
            keyCreationDate = new ColumnHeader();
            button4 = new Button();
            button1 = new Button();
            button3 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // keyList
            // 
            keyList.Columns.AddRange(new ColumnHeader[] { keyTypeHeader, keyNameHeader, keySavedLocationHeader, keyCreationDate });
            keyList.Location = new Point(39, 66);
            keyList.Name = "keyList";
            keyList.Size = new Size(650, 260);
            keyList.TabIndex = 1;
            keyList.UseCompatibleStateImageBehavior = false;
            keyList.View = View.Details;
            // 
            // keyTypeHeader
            // 
            keyTypeHeader.Text = "Key Type";
            keyTypeHeader.Width = 80;
            // 
            // keyNameHeader
            // 
            keyNameHeader.Text = "Key Name";
            keyNameHeader.Width = 150;
            // 
            // keySavedLocationHeader
            // 
            keySavedLocationHeader.Text = "Key Saved Location";
            keySavedLocationHeader.Width = 300;
            // 
            // keyCreationDate
            // 
            keyCreationDate.Text = "Creation Date";
            keyCreationDate.Width = 120;
            // 
            // button4
            // 
            button4.Location = new Point(39, 355);
            button4.Name = "button4";
            button4.Size = new Size(158, 45);
            button4.TabIndex = 5;
            button4.Text = "Add New Pair";
            button4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(203, 355);
            button1.Name = "button1";
            button1.Size = new Size(158, 45);
            button1.TabIndex = 6;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(367, 355);
            button3.Name = "button3";
            button3.Size = new Size(158, 45);
            button3.TabIndex = 7;
            button3.Text = "Export Key to New Location";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(531, 355);
            button2.Name = "button2";
            button2.Size = new Size(158, 45);
            button2.TabIndex = 8;
            button2.Text = "Open Key Location";
            button2.UseVisualStyleBackColor = true;
            // 
            // RSAKeyStoragePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(746, 588);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(button4);
            Controls.Add(keyList);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(746, 588);
            MinimumSize = new Size(746, 588);
            Name = "RSAKeyStoragePage";
            Text = "vv";
            ResumeLayout(false);
        }

        #endregion

        private ListView keyList;
        private ColumnHeader keyTypeHeader;
        private ColumnHeader keyNameHeader;
        private ColumnHeader keySavedLocationHeader;
        private ColumnHeader keyCreationDate;
        private Button button4;
        private Button button1;
        private Button button3;
        private Button button2;
    }
}