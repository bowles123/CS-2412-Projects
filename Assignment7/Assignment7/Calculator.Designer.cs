namespace Assignment7
{
    partial class calculatorForm
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
            this.beverageComboBox = new System.Windows.Forms.ComboBox();
            this.dessertComboBox = new System.Windows.Forms.ComboBox();
            this.entréeComboBox = new System.Windows.Forms.ComboBox();
            this.appetizerComboBox = new System.Windows.Forms.ComboBox();
            this.beverageNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.appetizerNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.dessertNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.entréeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.clearButton = new System.Windows.Forms.Button();
            this.enterButton = new System.Windows.Forms.Button();
            this.billTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.beverageNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appetizerNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dessertNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entréeNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // beverageComboBox
            // 
            this.beverageComboBox.FormattingEnabled = true;
            this.beverageComboBox.Items.AddRange(new object[] {
            "Soda",
            "Tea",
            "Coffee",
            "Mineral Water",
            "Juice",
            "Milk"});
            this.beverageComboBox.Location = new System.Drawing.Point(29, 40);
            this.beverageComboBox.Name = "beverageComboBox";
            this.beverageComboBox.Size = new System.Drawing.Size(121, 21);
            this.beverageComboBox.TabIndex = 0;
            this.beverageComboBox.Text = "Beverage";
            this.beverageComboBox.SelectedIndexChanged += new System.EventHandler(this.beverageComboBox_SelectedIndexChanged);
            // 
            // dessertComboBox
            // 
            this.dessertComboBox.FormattingEnabled = true;
            this.dessertComboBox.Items.AddRange(new object[] {
            "Apple Pie",
            "Sundae",
            "Carrot Cake",
            "Mud Pie",
            "Apple Crisp"});
            this.dessertComboBox.Location = new System.Drawing.Point(29, 143);
            this.dessertComboBox.Name = "dessertComboBox";
            this.dessertComboBox.Size = new System.Drawing.Size(121, 21);
            this.dessertComboBox.TabIndex = 1;
            this.dessertComboBox.Text = "Dessert";
            this.dessertComboBox.SelectedIndexChanged += new System.EventHandler(this.dessertComboBox_SelectedIndexChanged);
            // 
            // entréeComboBox
            // 
            this.entréeComboBox.FormattingEnabled = true;
            this.entréeComboBox.Items.AddRange(new object[] {
            "Seafood Alfredo",
            "Chicken Alfredo",
            "Chicken Picatta",
            "Turkey Club",
            "Lobster Pie",
            "Prime Rib",
            "Shrimp Scampi",
            "Turkey Dinner",
            "Stuffed Chicken"});
            this.entréeComboBox.Location = new System.Drawing.Point(29, 196);
            this.entréeComboBox.Name = "entréeComboBox";
            this.entréeComboBox.Size = new System.Drawing.Size(121, 21);
            this.entréeComboBox.TabIndex = 2;
            this.entréeComboBox.Text = "Entrée";
            this.entréeComboBox.SelectedIndexChanged += new System.EventHandler(this.entréeComboBox_SelectedIndexChanged);
            // 
            // appetizerComboBox
            // 
            this.appetizerComboBox.FormattingEnabled = true;
            this.appetizerComboBox.Items.AddRange(new object[] {
            "Buffalo Wings",
            "Buffalo Fingers",
            "Potato Skins",
            "Nachos",
            "Mushroom Caps",
            "Shrimp Cocktail",
            "Chips & Salsa"});
            this.appetizerComboBox.Location = new System.Drawing.Point(29, 94);
            this.appetizerComboBox.Name = "appetizerComboBox";
            this.appetizerComboBox.Size = new System.Drawing.Size(121, 21);
            this.appetizerComboBox.TabIndex = 3;
            this.appetizerComboBox.Text = "Appetizer";
            this.appetizerComboBox.SelectedIndexChanged += new System.EventHandler(this.appetizerComboBox_SelectedIndexChanged);
            // 
            // beverageNumericUpDown
            // 
            this.beverageNumericUpDown.Location = new System.Drawing.Point(167, 40);
            this.beverageNumericUpDown.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.beverageNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.beverageNumericUpDown.Name = "beverageNumericUpDown";
            this.beverageNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.beverageNumericUpDown.TabIndex = 4;
            this.beverageNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.beverageNumericUpDown.Visible = false;
            this.beverageNumericUpDown.ValueChanged += new System.EventHandler(this.beverageNumericUpDown_ValueChanged);
            // 
            // appetizerNumericUpDown
            // 
            this.appetizerNumericUpDown.Location = new System.Drawing.Point(167, 94);
            this.appetizerNumericUpDown.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.appetizerNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.appetizerNumericUpDown.Name = "appetizerNumericUpDown";
            this.appetizerNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.appetizerNumericUpDown.TabIndex = 5;
            this.appetizerNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.appetizerNumericUpDown.Visible = false;
            this.appetizerNumericUpDown.ValueChanged += new System.EventHandler(this.appetizerNumericUpDown_ValueChanged);
            // 
            // dessertNumericUpDown
            // 
            this.dessertNumericUpDown.Location = new System.Drawing.Point(167, 143);
            this.dessertNumericUpDown.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.dessertNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.dessertNumericUpDown.Name = "dessertNumericUpDown";
            this.dessertNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.dessertNumericUpDown.TabIndex = 6;
            this.dessertNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.dessertNumericUpDown.Visible = false;
            this.dessertNumericUpDown.ValueChanged += new System.EventHandler(this.dessertNumericUpDown_ValueChanged);
            // 
            // entréeNumericUpDown
            // 
            this.entréeNumericUpDown.Location = new System.Drawing.Point(167, 196);
            this.entréeNumericUpDown.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.entréeNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.entréeNumericUpDown.Name = "entréeNumericUpDown";
            this.entréeNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.entréeNumericUpDown.TabIndex = 7;
            this.entréeNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.entréeNumericUpDown.Visible = false;
            this.entréeNumericUpDown.ValueChanged += new System.EventHandler(this.entréeNumericUpDown_ValueChanged);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(29, 239);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 8;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(167, 239);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(75, 23);
            this.enterButton.TabIndex = 9;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // billTextBox
            // 
            this.billTextBox.Location = new System.Drawing.Point(29, 283);
            this.billTextBox.Multiline = true;
            this.billTextBox.Name = "billTextBox";
            this.billTextBox.ReadOnly = true;
            this.billTextBox.Size = new System.Drawing.Size(258, 73);
            this.billTextBox.TabIndex = 10;
            this.billTextBox.Text = "SubTotal = ";
            this.billTextBox.Visible = false;
            // 
            // calculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 368);
            this.Controls.Add(this.billTextBox);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.entréeNumericUpDown);
            this.Controls.Add(this.dessertNumericUpDown);
            this.Controls.Add(this.appetizerNumericUpDown);
            this.Controls.Add(this.beverageNumericUpDown);
            this.Controls.Add(this.appetizerComboBox);
            this.Controls.Add(this.entréeComboBox);
            this.Controls.Add(this.dessertComboBox);
            this.Controls.Add(this.beverageComboBox);
            this.Name = "calculatorForm";
            this.Text = "Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.beverageNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appetizerNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dessertNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entréeNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox beverageComboBox;
        private System.Windows.Forms.ComboBox dessertComboBox;
        private System.Windows.Forms.ComboBox entréeComboBox;
        private System.Windows.Forms.ComboBox appetizerComboBox;
        private System.Windows.Forms.NumericUpDown beverageNumericUpDown;
        private System.Windows.Forms.NumericUpDown appetizerNumericUpDown;
        private System.Windows.Forms.NumericUpDown dessertNumericUpDown;
        private System.Windows.Forms.NumericUpDown entréeNumericUpDown;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.TextBox billTextBox;
    }
}