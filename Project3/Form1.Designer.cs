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
            this.SuspendLayout();
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(340, 323);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(75, 23);
            this.showButton.TabIndex = 0;
            this.showButton.Text = "button1";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // fruitsListBox
            // 
            this.fruitsListBox.FormattingEnabled = true;
            this.fruitsListBox.ItemHeight = 16;
            this.fruitsListBox.Location = new System.Drawing.Point(46, 262);
            this.fruitsListBox.Name = "fruitsListBox";
            this.fruitsListBox.Size = new System.Drawing.Size(163, 84);
            this.fruitsListBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 235);
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
            this.originalWordListBox.Location = new System.Drawing.Point(46, 120);
            this.originalWordListBox.Name = "originalWordListBox";
            this.originalWordListBox.Size = new System.Drawing.Size(163, 100);
            this.originalWordListBox.TabIndex = 3;
            this.originalWordListBox.SelectedIndexChanged += new System.EventHandler(this.originalWordListBox_SelectedIndexChanged);
            // 
            // sortedFruitListBox
            // 
            this.sortedFruitListBox.FormattingEnabled = true;
            this.sortedFruitListBox.ItemHeight = 16;
            this.sortedFruitListBox.Location = new System.Drawing.Point(340, 120);
            this.sortedFruitListBox.Name = "sortedFruitListBox";
            this.sortedFruitListBox.Size = new System.Drawing.Size(159, 100);
            this.sortedFruitListBox.TabIndex = 4;
            this.sortedFruitListBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(340, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sorted Alphabetically:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "From Text File:";
            // 
            // longestWordListBox
            // 
            this.longestWordListBox.FormattingEnabled = true;
            this.longestWordListBox.ItemHeight = 16;
            this.longestWordListBox.Location = new System.Drawing.Point(603, 120);
            this.longestWordListBox.Name = "longestWordListBox";
            this.longestWordListBox.Size = new System.Drawing.Size(120, 84);
            this.longestWordListBox.TabIndex = 7;
            // 
            // mostVowelsListBox
            // 
            this.mostVowelsListBox.FormattingEnabled = true;
            this.mostVowelsListBox.ItemHeight = 16;
            this.mostVowelsListBox.Location = new System.Drawing.Point(603, 307);
            this.mostVowelsListBox.Name = "mostVowelsListBox";
            this.mostVowelsListBox.Size = new System.Drawing.Size(120, 84);
            this.mostVowelsListBox.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Text = "Form1";
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
    }
}

