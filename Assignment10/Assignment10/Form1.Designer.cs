namespace Assignment10
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
            this.browserListView = new System.Windows.Forms.ListView();
            this.directoryTreeView = new System.Windows.Forms.TreeView();
            this.pathTextBox = new System.Windows.Forms.TextBox();
            this.pathLabel = new System.Windows.Forms.Label();
            this.pathEnterButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // browserListView
            // 
            this.browserListView.Location = new System.Drawing.Point(151, 30);
            this.browserListView.Name = "browserListView";
            this.browserListView.Size = new System.Drawing.Size(121, 97);
            this.browserListView.TabIndex = 0;
            this.browserListView.UseCompatibleStateImageBehavior = false;
            this.browserListView.SelectedIndexChanged += new System.EventHandler(this.browserListView_Click);
            // 
            // directoryTreeView
            // 
            this.directoryTreeView.Location = new System.Drawing.Point(12, 30);
            this.directoryTreeView.Name = "directoryTreeView";
            this.directoryTreeView.Size = new System.Drawing.Size(121, 97);
            this.directoryTreeView.TabIndex = 1;
            // 
            // pathTextBox
            // 
            this.pathTextBox.Location = new System.Drawing.Point(95, 162);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.Size = new System.Drawing.Size(100, 20);
            this.pathTextBox.TabIndex = 2;
            // 
            // pathLabel
            // 
            this.pathLabel.AutoSize = true;
            this.pathLabel.Location = new System.Drawing.Point(12, 165);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(77, 13);
            this.pathLabel.TabIndex = 3;
            this.pathLabel.Text = "Enter the path:";
            // 
            // pathEnterButton
            // 
            this.pathEnterButton.Location = new System.Drawing.Point(201, 143);
            this.pathEnterButton.Name = "pathEnterButton";
            this.pathEnterButton.Size = new System.Drawing.Size(75, 23);
            this.pathEnterButton.TabIndex = 4;
            this.pathEnterButton.Text = "Enter";
            this.pathEnterButton.UseVisualStyleBackColor = true;
            this.pathEnterButton.Click += new System.EventHandler(this.pathEnterButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(201, 172);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 5;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.pathEnterButton);
            this.Controls.Add(this.pathLabel);
            this.Controls.Add(this.pathTextBox);
            this.Controls.Add(this.directoryTreeView);
            this.Controls.Add(this.browserListView);
            this.Name = "Form1";
            this.Text = "File Explorer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView browserListView;
        private System.Windows.Forms.TreeView directoryTreeView;
        private System.Windows.Forms.TextBox pathTextBox;
        private System.Windows.Forms.Label pathLabel;
        private System.Windows.Forms.Button pathEnterButton;
        private System.Windows.Forms.Button deleteButton;
    }
}

