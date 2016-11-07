namespace Assignment8
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
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.enterButton = new System.Windows.Forms.Button();
            this.spamWordsListBox = new System.Windows.Forms.ListBox();
            this.scoreTextBox = new System.Windows.Forms.TextBox();
            this.addTextBox = new System.Windows.Forms.TextBox();
            this.spamWordAddButton = new System.Windows.Forms.Button();
            this.scannedTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(13, 12);
            this.emailTextBox.Multiline = true;
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(149, 105);
            this.emailTextBox.TabIndex = 0;
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(180, 51);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(75, 23);
            this.enterButton.TabIndex = 1;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // spamWordsListBox
            // 
            this.spamWordsListBox.FormattingEnabled = true;
            this.spamWordsListBox.Items.AddRange(new object[] {
            "$$$",
            "beneficiary",
            "cash",
            "cents on the dollar",
            "claims",
            "cost",
            "discount",
            "free",
            "hidden assets",
            "incredible deal",
            "loans",
            "money",
            "mortage rates",
            "one hundered percent free",
            "price",
            "quote",
            "save big money",
            "subject to credit",
            "unsecured debt",
            "affordable",
            "best price",
            "cash bonus",
            "cheap",
            "collect",
            "credit",
            "earn",
            "fast cash",
            "hidden charges",
            "insurance",
            "lowest price",
            "money back",
            "no cost",
            "only $",
            "profits",
            "refinance",
            "save up to",
            "they keep your money - no refund!",
            "us dollars",
            "bargain",
            "big Bucks",
            "cashcashcash",
            "check",
            "compare rates",
            "credit bureaus",
            "easy terms",
            "for just $XXX",
            "income",
            "investment",
            "million dollars",
            "mortgage",
            "no fees",
            "pennies a day",
            "pure profit",
            "save $",
            "serious cash",
            "unsecured credit",
            "why pay more?"});
            this.spamWordsListBox.Location = new System.Drawing.Point(294, 12);
            this.spamWordsListBox.Name = "spamWordsListBox";
            this.spamWordsListBox.Size = new System.Drawing.Size(149, 108);
            this.spamWordsListBox.TabIndex = 2;
            // 
            // scoreTextBox
            // 
            this.scoreTextBox.Location = new System.Drawing.Point(294, 163);
            this.scoreTextBox.Multiline = true;
            this.scoreTextBox.Name = "scoreTextBox";
            this.scoreTextBox.ReadOnly = true;
            this.scoreTextBox.Size = new System.Drawing.Size(146, 44);
            this.scoreTextBox.TabIndex = 4;
            this.scoreTextBox.Text = "Likely Hood of Spam: ";
            this.scoreTextBox.Visible = false;
            // 
            // addTextBox
            // 
            this.addTextBox.Location = new System.Drawing.Point(155, 163);
            this.addTextBox.Name = "addTextBox";
            this.addTextBox.Size = new System.Drawing.Size(100, 20);
            this.addTextBox.TabIndex = 5;
            // 
            // spamWordAddButton
            // 
            this.spamWordAddButton.Location = new System.Drawing.Point(155, 203);
            this.spamWordAddButton.Name = "spamWordAddButton";
            this.spamWordAddButton.Size = new System.Drawing.Size(75, 23);
            this.spamWordAddButton.TabIndex = 7;
            this.spamWordAddButton.Text = "Add";
            this.spamWordAddButton.UseVisualStyleBackColor = true;
            this.spamWordAddButton.Click += new System.EventHandler(this.spamWordAddButton_Click);
            // 
            // scannedTextBox
            // 
            this.scannedTextBox.Location = new System.Drawing.Point(13, 162);
            this.scannedTextBox.Multiline = true;
            this.scannedTextBox.Name = "scannedTextBox";
            this.scannedTextBox.ReadOnly = true;
            this.scannedTextBox.Size = new System.Drawing.Size(121, 64);
            this.scannedTextBox.TabIndex = 8;
            this.scannedTextBox.Text = "Email has been scanned, enter a new email to scan again.";
            this.scannedTextBox.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 262);
            this.Controls.Add(this.scannedTextBox);
            this.Controls.Add(this.spamWordAddButton);
            this.Controls.Add(this.addTextBox);
            this.Controls.Add(this.scoreTextBox);
            this.Controls.Add(this.spamWordsListBox);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.emailTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.ListBox spamWordsListBox;
        private System.Windows.Forms.TextBox scoreTextBox;
        private System.Windows.Forms.TextBox addTextBox;
        private System.Windows.Forms.Button spamWordAddButton;
        private System.Windows.Forms.TextBox scannedTextBox;

    }
}

