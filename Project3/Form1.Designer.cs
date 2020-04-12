namespace Project3
{
    partial class Form1
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
            this.showButton = new System.Windows.Forms.Button();
            this.fruitsListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.originalWordListBox = new System.Windows.Forms.ListBox();
            this.sortedFruitListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.longestWordListBox = new System.Windows.Forms.ListBox();
            this.mostVowelsListBox = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(524, 246);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(163, 39);
            this.showButton.TabIndex = 0;
            this.showButton.Text = "RUN";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // fruitsListBox
            // 
            this.fruitsListBox.FormattingEnabled = true;
            this.fruitsListBox.ItemHeight = 16;
            this.fruitsListBox.Location = new System.Drawing.Point(46, 100);
            this.fruitsListBox.Name = "fruitsListBox";
            this.fruitsListBox.Size = new System.Drawing.Size(163, 100);
            this.fruitsListBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "All Words in Lower-Case:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // originalWordListBox
            // 
            this.originalWordListBox.FormattingEnabled = true;
            this.originalWordListBox.ItemHeight = 16;
            this.originalWordListBox.Location = new System.Drawing.Point(46, 246);
            this.originalWordListBox.Name = "originalWordListBox";
            this.originalWordListBox.Size = new System.Drawing.Size(163, 100);
            this.originalWordListBox.TabIndex = 3;
            this.originalWordListBox.SelectedIndexChanged += new System.EventHandler(this.originalWordListBox_SelectedIndexChanged);
            // 
            // sortedFruitListBox
            // 
            this.sortedFruitListBox.FormattingEnabled = true;
            this.sortedFruitListBox.ItemHeight = 16;
            this.sortedFruitListBox.Location = new System.Drawing.Point(289, 100);
            this.sortedFruitListBox.Name = "sortedFruitListBox";
            this.sortedFruitListBox.Size = new System.Drawing.Size(163, 100);
            this.sortedFruitListBox.TabIndex = 4;
            this.sortedFruitListBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(286, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sorted Alphabetically:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Original Text from File:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // longestWordListBox
            // 
            this.longestWordListBox.FormattingEnabled = true;
            this.longestWordListBox.ItemHeight = 16;
            this.longestWordListBox.Location = new System.Drawing.Point(289, 246);
            this.longestWordListBox.Name = "longestWordListBox";
            this.longestWordListBox.Size = new System.Drawing.Size(163, 100);
            this.longestWordListBox.TabIndex = 7;
            // 
            // mostVowelsListBox
            // 
            this.mostVowelsListBox.FormattingEnabled = true;
            this.mostVowelsListBox.ItemHeight = 16;
            this.mostVowelsListBox.Location = new System.Drawing.Point(524, 100);
            this.mostVowelsListBox.Name = "mostVowelsListBox";
            this.mostVowelsListBox.Size = new System.Drawing.Size(163, 100);
            this.mostVowelsListBox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(286, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Longest Word:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(521, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Word with Most Vowels:";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(524, 307);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(163, 39);
            this.saveButton.TabIndex = 13;
            this.saveButton.Text = "SAVE";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mostVowelsListBox);
            this.Controls.Add(this.longestWordListBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sortedFruitListBox);
            this.Controls.Add(this.originalWordListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fruitsListBox);
            this.Controls.Add(this.showButton);
            this.Name = "Form1";
            this.Text = "Word Decoder";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.ListBox fruitsListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox originalWordListBox;
        private System.Windows.Forms.ListBox sortedFruitListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox longestWordListBox;
        private System.Windows.Forms.ListBox mostVowelsListBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button saveButton;
    }
}

