namespace Assignment5
{
    partial class CarbonFootprintCalc
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
            this.emissionListBox = new System.Windows.Forms.ListBox();
            this.transportationSubListBox = new System.Windows.Forms.ListBox();
            this.householdSubListBox = new System.Windows.Forms.ListBox();
            this.dietCategoriesTextBox = new System.Windows.Forms.TextBox();
            this.serviceCategoriesTextBox = new System.Windows.Forms.TextBox();
            this.vehicleMilesTextBox = new System.Windows.Forms.TextBox();
            this.airMilesTextBox = new System.Windows.Forms.TextBox();
            this.electricityBillTextBox = new System.Windows.Forms.TextBox();
            this.gasBillTextBox = new System.Windows.Forms.TextBox();
            this.fuelBillTextBox = new System.Windows.Forms.TextBox();
            this.propaneBillTextBox = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.footprintTextbox = new System.Windows.Forms.TextBox();
            this.dietDollarsTextBox = new System.Windows.Forms.TextBox();
            this.fuelPriceTextBox = new System.Windows.Forms.TextBox();
            this.gasPriceTextBox = new System.Windows.Forms.TextBox();
            this.electricityPriceTextBox = new System.Windows.Forms.TextBox();
            this.vehicleEfficiencyTextBox = new System.Windows.Forms.TextBox();
            this.serviceDollarsTextBox = new System.Windows.Forms.TextBox();
            this.propanePriceTextBox = new System.Windows.Forms.TextBox();
            this.propaneEnterButton = new System.Windows.Forms.Button();
            this.fuelEnterButton = new System.Windows.Forms.Button();
            this.gasEnterButton = new System.Windows.Forms.Button();
            this.electricityEnterButton = new System.Windows.Forms.Button();
            this.serviceEnterButton = new System.Windows.Forms.Button();
            this.dietEnterButton = new System.Windows.Forms.Button();
            this.propaneBillEntryTextBox = new System.Windows.Forms.TextBox();
            this.fuelBillEntryTextBox = new System.Windows.Forms.TextBox();
            this.gasBillEntryTextBox = new System.Windows.Forms.TextBox();
            this.electricityBillEntryBox = new System.Windows.Forms.TextBox();
            this.airMilesEntryTextBox = new System.Windows.Forms.TextBox();
            this.vehicleMilesEntryTextBox = new System.Windows.Forms.TextBox();
            this.serviceCategoriesEntryTextBox = new System.Windows.Forms.TextBox();
            this.dietCategoriesEntryTextBox = new System.Windows.Forms.TextBox();
            this.propanePriceEntryTextBox = new System.Windows.Forms.TextBox();
            this.fuelPriceEntryTextBox = new System.Windows.Forms.TextBox();
            this.gasPriceEntryTextBox = new System.Windows.Forms.TextBox();
            this.electricityPriceEntryTextBox = new System.Windows.Forms.TextBox();
            this.vehicleEfficiencyEntryTextBox = new System.Windows.Forms.TextBox();
            this.serviceDollarsEntryBox = new System.Windows.Forms.TextBox();
            this.dietDollarsEntryTextBox = new System.Windows.Forms.TextBox();
            this.calcCarbonFootprintButton = new System.Windows.Forms.Button();
            this.vehicleEnterButton = new System.Windows.Forms.Button();
            this.airEnterButton = new System.Windows.Forms.Button();
            this.fuelFootprintTextBox = new System.Windows.Forms.TextBox();
            this.airFootprintTextBox = new System.Windows.Forms.TextBox();
            this.propaneFootprintTextBox = new System.Windows.Forms.TextBox();
            this.gasFootprintTextBox = new System.Windows.Forms.TextBox();
            this.electricityFootprintTextBox = new System.Windows.Forms.TextBox();
            this.vehicleFootprintTextBox = new System.Windows.Forms.TextBox();
            this.serviceFootprintTextBox = new System.Windows.Forms.TextBox();
            this.dietFootprintTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // emissionListBox
            // 
            this.emissionListBox.FormattingEnabled = true;
            this.emissionListBox.Items.AddRange(new object[] {
            "Transportation Emission",
            "Household Energy Emission",
            "Diet & Eating Habits Emission",
            "Service & Goods Emission"});
            this.emissionListBox.Location = new System.Drawing.Point(13, 13);
            this.emissionListBox.Name = "emissionListBox";
            this.emissionListBox.Size = new System.Drawing.Size(148, 56);
            this.emissionListBox.TabIndex = 0;
            this.emissionListBox.SelectedIndexChanged += new System.EventHandler(this.emissionListBox_SelectedIndexChanged);
            // 
            // transportationSubListBox
            // 
            this.transportationSubListBox.FormattingEnabled = true;
            this.transportationSubListBox.Items.AddRange(new object[] {
            "Vehicle Emission",
            "Air Travel Emission"});
            this.transportationSubListBox.Location = new System.Drawing.Point(50, 75);
            this.transportationSubListBox.Name = "transportationSubListBox";
            this.transportationSubListBox.Size = new System.Drawing.Size(98, 30);
            this.transportationSubListBox.TabIndex = 1;
            this.transportationSubListBox.Visible = false;
            this.transportationSubListBox.SelectedIndexChanged += new System.EventHandler(this.transportationSubListBox_SelectedIndexChanged);
            // 
            // householdSubListBox
            // 
            this.householdSubListBox.FormattingEnabled = true;
            this.householdSubListBox.Items.AddRange(new object[] {
            "Electricity Emission",
            "Natural Gas Emission",
            "Fuel Oil Emission ",
            "Propane Emission"});
            this.householdSubListBox.Location = new System.Drawing.Point(40, 170);
            this.householdSubListBox.Name = "householdSubListBox";
            this.householdSubListBox.Size = new System.Drawing.Size(108, 56);
            this.householdSubListBox.TabIndex = 2;
            this.householdSubListBox.Visible = false;
            this.householdSubListBox.SelectedIndexChanged += new System.EventHandler(this.householdSubListBox_SelectedIndexChanged);
            // 
            // dietCategoriesTextBox
            // 
            this.dietCategoriesTextBox.Location = new System.Drawing.Point(167, 13);
            this.dietCategoriesTextBox.Name = "dietCategoriesTextBox";
            this.dietCategoriesTextBox.ReadOnly = true;
            this.dietCategoriesTextBox.Size = new System.Drawing.Size(101, 20);
            this.dietCategoriesTextBox.TabIndex = 3;
            this.dietCategoriesTextBox.Text = "DE Num Categories:";
            this.dietCategoriesTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dietCategoriesTextBox.Visible = false;
            // 
            // serviceCategoriesTextBox
            // 
            this.serviceCategoriesTextBox.Location = new System.Drawing.Point(168, 40);
            this.serviceCategoriesTextBox.Name = "serviceCategoriesTextBox";
            this.serviceCategoriesTextBox.ReadOnly = true;
            this.serviceCategoriesTextBox.Size = new System.Drawing.Size(107, 20);
            this.serviceCategoriesTextBox.TabIndex = 4;
            this.serviceCategoriesTextBox.Text = "SG Num Categories:";
            this.serviceCategoriesTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.serviceCategoriesTextBox.Visible = false;
            // 
            // vehicleMilesTextBox
            // 
            this.vehicleMilesTextBox.Location = new System.Drawing.Point(154, 75);
            this.vehicleMilesTextBox.Name = "vehicleMilesTextBox";
            this.vehicleMilesTextBox.ReadOnly = true;
            this.vehicleMilesTextBox.Size = new System.Drawing.Size(139, 20);
            this.vehicleMilesTextBox.TabIndex = 6;
            this.vehicleMilesTextBox.Text = "Total Weekly Miles Driven:";
            this.vehicleMilesTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.vehicleMilesTextBox.Visible = false;
            // 
            // airMilesTextBox
            // 
            this.airMilesTextBox.Location = new System.Drawing.Point(168, 102);
            this.airMilesTextBox.Name = "airMilesTextBox";
            this.airMilesTextBox.ReadOnly = true;
            this.airMilesTextBox.Size = new System.Drawing.Size(107, 20);
            this.airMilesTextBox.TabIndex = 7;
            this.airMilesTextBox.Text = "Yearly Miles Flown:";
            this.airMilesTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.airMilesTextBox.Visible = false;
            // 
            // electricityBillTextBox
            // 
            this.electricityBillTextBox.Location = new System.Drawing.Point(168, 143);
            this.electricityBillTextBox.Name = "electricityBillTextBox";
            this.electricityBillTextBox.ReadOnly = true;
            this.electricityBillTextBox.Size = new System.Drawing.Size(100, 20);
            this.electricityBillTextBox.TabIndex = 8;
            this.electricityBillTextBox.Text = "(E) Monthly Bill:";
            this.electricityBillTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.electricityBillTextBox.Visible = false;
            // 
            // gasBillTextBox
            // 
            this.gasBillTextBox.Location = new System.Drawing.Point(168, 170);
            this.gasBillTextBox.Name = "gasBillTextBox";
            this.gasBillTextBox.ReadOnly = true;
            this.gasBillTextBox.Size = new System.Drawing.Size(100, 20);
            this.gasBillTextBox.TabIndex = 9;
            this.gasBillTextBox.Text = "NG Monthly Bill:";
            this.gasBillTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gasBillTextBox.Visible = false;
            // 
            // fuelBillTextBox
            // 
            this.fuelBillTextBox.Location = new System.Drawing.Point(168, 197);
            this.fuelBillTextBox.Name = "fuelBillTextBox";
            this.fuelBillTextBox.ReadOnly = true;
            this.fuelBillTextBox.Size = new System.Drawing.Size(100, 20);
            this.fuelBillTextBox.TabIndex = 10;
            this.fuelBillTextBox.Text = "FO Monthly Bill:";
            this.fuelBillTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.fuelBillTextBox.Visible = false;
            // 
            // propaneBillTextBox
            // 
            this.propaneBillTextBox.Location = new System.Drawing.Point(168, 224);
            this.propaneBillTextBox.Name = "propaneBillTextBox";
            this.propaneBillTextBox.ReadOnly = true;
            this.propaneBillTextBox.Size = new System.Drawing.Size(100, 20);
            this.propaneBillTextBox.TabIndex = 11;
            this.propaneBillTextBox.Text = "(P) Monthly Bill:";
            this.propaneBillTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.propaneBillTextBox.Visible = false;
            // 
            // footprintTextbox
            // 
            this.footprintTextbox.Location = new System.Drawing.Point(240, 329);
            this.footprintTextbox.Multiline = true;
            this.footprintTextbox.Name = "footprintTextbox";
            this.footprintTextbox.ReadOnly = true;
            this.footprintTextbox.Size = new System.Drawing.Size(291, 25);
            this.footprintTextbox.TabIndex = 20;
            this.footprintTextbox.Text = "The calculated carbon footprint is: ";
            this.footprintTextbox.Visible = false;
            // 
            // dietDollarsTextBox
            // 
            this.dietDollarsTextBox.Location = new System.Drawing.Point(405, 13);
            this.dietDollarsTextBox.Name = "dietDollarsTextBox";
            this.dietDollarsTextBox.ReadOnly = true;
            this.dietDollarsTextBox.Size = new System.Drawing.Size(100, 20);
            this.dietDollarsTextBox.TabIndex = 21;
            this.dietDollarsTextBox.Text = "DE Total Spent:";
            this.dietDollarsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dietDollarsTextBox.Visible = false;
            // 
            // fuelPriceTextBox
            // 
            this.fuelPriceTextBox.Location = new System.Drawing.Point(380, 197);
            this.fuelPriceTextBox.Name = "fuelPriceTextBox";
            this.fuelPriceTextBox.ReadOnly = true;
            this.fuelPriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.fuelPriceTextBox.TabIndex = 22;
            this.fuelPriceTextBox.Text = "FO Price/Gallon:";
            this.fuelPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.fuelPriceTextBox.Visible = false;
            // 
            // gasPriceTextBox
            // 
            this.gasPriceTextBox.Location = new System.Drawing.Point(380, 170);
            this.gasPriceTextBox.Name = "gasPriceTextBox";
            this.gasPriceTextBox.ReadOnly = true;
            this.gasPriceTextBox.Size = new System.Drawing.Size(117, 20);
            this.gasPriceTextBox.TabIndex = 23;
            this.gasPriceTextBox.Text = "NG Price/1000 ft^3:";
            this.gasPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gasPriceTextBox.Visible = false;
            // 
            // electricityPriceTextBox
            // 
            this.electricityPriceTextBox.Location = new System.Drawing.Point(380, 143);
            this.electricityPriceTextBox.Name = "electricityPriceTextBox";
            this.electricityPriceTextBox.ReadOnly = true;
            this.electricityPriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.electricityPriceTextBox.TabIndex = 24;
            this.electricityPriceTextBox.Text = "(E) Price/KWH:";
            this.electricityPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.electricityPriceTextBox.Visible = false;
            // 
            // vehicleEfficiencyTextBox
            // 
            this.vehicleEfficiencyTextBox.Location = new System.Drawing.Point(405, 72);
            this.vehicleEfficiencyTextBox.Name = "vehicleEfficiencyTextBox";
            this.vehicleEfficiencyTextBox.ReadOnly = true;
            this.vehicleEfficiencyTextBox.Size = new System.Drawing.Size(100, 20);
            this.vehicleEfficiencyTextBox.TabIndex = 26;
            this.vehicleEfficiencyTextBox.Text = "Avg Fuel Efficiency:";
            this.vehicleEfficiencyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.vehicleEfficiencyTextBox.Visible = false;
            // 
            // serviceDollarsTextBox
            // 
            this.serviceDollarsTextBox.Location = new System.Drawing.Point(405, 41);
            this.serviceDollarsTextBox.Name = "serviceDollarsTextBox";
            this.serviceDollarsTextBox.ReadOnly = true;
            this.serviceDollarsTextBox.Size = new System.Drawing.Size(100, 20);
            this.serviceDollarsTextBox.TabIndex = 27;
            this.serviceDollarsTextBox.Text = "SG Total Spent:";
            this.serviceDollarsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.serviceDollarsTextBox.Visible = false;
            // 
            // propanePriceTextBox
            // 
            this.propanePriceTextBox.Location = new System.Drawing.Point(380, 224);
            this.propanePriceTextBox.Name = "propanePriceTextBox";
            this.propanePriceTextBox.ReadOnly = true;
            this.propanePriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.propanePriceTextBox.TabIndex = 28;
            this.propanePriceTextBox.Text = "(P) Price/Gallon:";
            this.propanePriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.propanePriceTextBox.Visible = false;
            // 
            // propaneEnterButton
            // 
            this.propaneEnterButton.Location = new System.Drawing.Point(617, 221);
            this.propaneEnterButton.Name = "propaneEnterButton";
            this.propaneEnterButton.Size = new System.Drawing.Size(75, 23);
            this.propaneEnterButton.TabIndex = 29;
            this.propaneEnterButton.Text = "Enter";
            this.propaneEnterButton.UseVisualStyleBackColor = true;
            this.propaneEnterButton.Visible = false;
            this.propaneEnterButton.Click += new System.EventHandler(this.propaneEnterButton_Click);
            // 
            // fuelEnterButton
            // 
            this.fuelEnterButton.Location = new System.Drawing.Point(617, 194);
            this.fuelEnterButton.Name = "fuelEnterButton";
            this.fuelEnterButton.Size = new System.Drawing.Size(75, 23);
            this.fuelEnterButton.TabIndex = 30;
            this.fuelEnterButton.Text = "Enter";
            this.fuelEnterButton.UseVisualStyleBackColor = true;
            this.fuelEnterButton.Visible = false;
            this.fuelEnterButton.Click += new System.EventHandler(this.fuelEnterButton_Click);
            // 
            // gasEnterButton
            // 
            this.gasEnterButton.Location = new System.Drawing.Point(617, 167);
            this.gasEnterButton.Name = "gasEnterButton";
            this.gasEnterButton.Size = new System.Drawing.Size(75, 23);
            this.gasEnterButton.TabIndex = 31;
            this.gasEnterButton.Text = "Enter";
            this.gasEnterButton.UseVisualStyleBackColor = true;
            this.gasEnterButton.Visible = false;
            this.gasEnterButton.Click += new System.EventHandler(this.gasEnterButton_Click);
            // 
            // electricityEnterButton
            // 
            this.electricityEnterButton.Location = new System.Drawing.Point(617, 140);
            this.electricityEnterButton.Name = "electricityEnterButton";
            this.electricityEnterButton.Size = new System.Drawing.Size(75, 23);
            this.electricityEnterButton.TabIndex = 32;
            this.electricityEnterButton.Text = "Enter";
            this.electricityEnterButton.UseVisualStyleBackColor = true;
            this.electricityEnterButton.Visible = false;
            this.electricityEnterButton.Click += new System.EventHandler(this.electricityEnterButton_Click);
            // 
            // serviceEnterButton
            // 
            this.serviceEnterButton.Location = new System.Drawing.Point(617, 37);
            this.serviceEnterButton.Name = "serviceEnterButton";
            this.serviceEnterButton.Size = new System.Drawing.Size(75, 23);
            this.serviceEnterButton.TabIndex = 35;
            this.serviceEnterButton.Text = "Enter";
            this.serviceEnterButton.UseVisualStyleBackColor = true;
            this.serviceEnterButton.Visible = false;
            this.serviceEnterButton.Click += new System.EventHandler(this.serviceEnterButton_Click);
            // 
            // dietEnterButton
            // 
            this.dietEnterButton.Location = new System.Drawing.Point(617, 10);
            this.dietEnterButton.Name = "dietEnterButton";
            this.dietEnterButton.Size = new System.Drawing.Size(75, 23);
            this.dietEnterButton.TabIndex = 36;
            this.dietEnterButton.Text = "Enter";
            this.dietEnterButton.UseVisualStyleBackColor = true;
            this.dietEnterButton.Visible = false;
            this.dietEnterButton.Click += new System.EventHandler(this.dietEnterButton_Click);
            // 
            // propaneBillEntryTextBox
            // 
            this.propaneBillEntryTextBox.Location = new System.Drawing.Point(274, 224);
            this.propaneBillEntryTextBox.Name = "propaneBillEntryTextBox";
            this.propaneBillEntryTextBox.Size = new System.Drawing.Size(100, 20);
            this.propaneBillEntryTextBox.TabIndex = 37;
            this.propaneBillEntryTextBox.Visible = false;
            // 
            // fuelBillEntryTextBox
            // 
            this.fuelBillEntryTextBox.Location = new System.Drawing.Point(275, 197);
            this.fuelBillEntryTextBox.Name = "fuelBillEntryTextBox";
            this.fuelBillEntryTextBox.Size = new System.Drawing.Size(100, 20);
            this.fuelBillEntryTextBox.TabIndex = 38;
            this.fuelBillEntryTextBox.Visible = false;
            // 
            // gasBillEntryTextBox
            // 
            this.gasBillEntryTextBox.Location = new System.Drawing.Point(274, 170);
            this.gasBillEntryTextBox.Name = "gasBillEntryTextBox";
            this.gasBillEntryTextBox.Size = new System.Drawing.Size(100, 20);
            this.gasBillEntryTextBox.TabIndex = 39;
            this.gasBillEntryTextBox.Visible = false;
            // 
            // electricityBillEntryBox
            // 
            this.electricityBillEntryBox.Location = new System.Drawing.Point(274, 143);
            this.electricityBillEntryBox.Name = "electricityBillEntryBox";
            this.electricityBillEntryBox.Size = new System.Drawing.Size(100, 20);
            this.electricityBillEntryBox.TabIndex = 40;
            this.electricityBillEntryBox.Visible = false;
            // 
            // airMilesEntryTextBox
            // 
            this.airMilesEntryTextBox.Location = new System.Drawing.Point(299, 101);
            this.airMilesEntryTextBox.Name = "airMilesEntryTextBox";
            this.airMilesEntryTextBox.Size = new System.Drawing.Size(100, 20);
            this.airMilesEntryTextBox.TabIndex = 41;
            this.airMilesEntryTextBox.Visible = false;
            // 
            // vehicleMilesEntryTextBox
            // 
            this.vehicleMilesEntryTextBox.Location = new System.Drawing.Point(299, 74);
            this.vehicleMilesEntryTextBox.Name = "vehicleMilesEntryTextBox";
            this.vehicleMilesEntryTextBox.Size = new System.Drawing.Size(100, 20);
            this.vehicleMilesEntryTextBox.TabIndex = 42;
            this.vehicleMilesEntryTextBox.Visible = false;
            // 
            // serviceCategoriesEntryTextBox
            // 
            this.serviceCategoriesEntryTextBox.Location = new System.Drawing.Point(299, 40);
            this.serviceCategoriesEntryTextBox.Name = "serviceCategoriesEntryTextBox";
            this.serviceCategoriesEntryTextBox.Size = new System.Drawing.Size(100, 20);
            this.serviceCategoriesEntryTextBox.TabIndex = 43;
            this.serviceCategoriesEntryTextBox.Visible = false;
            // 
            // dietCategoriesEntryTextBox
            // 
            this.dietCategoriesEntryTextBox.Location = new System.Drawing.Point(299, 13);
            this.dietCategoriesEntryTextBox.Name = "dietCategoriesEntryTextBox";
            this.dietCategoriesEntryTextBox.Size = new System.Drawing.Size(100, 20);
            this.dietCategoriesEntryTextBox.TabIndex = 44;
            this.dietCategoriesEntryTextBox.Visible = false;
            // 
            // propanePriceEntryTextBox
            // 
            this.propanePriceEntryTextBox.Location = new System.Drawing.Point(511, 224);
            this.propanePriceEntryTextBox.Name = "propanePriceEntryTextBox";
            this.propanePriceEntryTextBox.Size = new System.Drawing.Size(100, 20);
            this.propanePriceEntryTextBox.TabIndex = 45;
            this.propanePriceEntryTextBox.Visible = false;
            // 
            // fuelPriceEntryTextBox
            // 
            this.fuelPriceEntryTextBox.Location = new System.Drawing.Point(511, 197);
            this.fuelPriceEntryTextBox.Name = "fuelPriceEntryTextBox";
            this.fuelPriceEntryTextBox.Size = new System.Drawing.Size(100, 20);
            this.fuelPriceEntryTextBox.TabIndex = 46;
            this.fuelPriceEntryTextBox.Visible = false;
            // 
            // gasPriceEntryTextBox
            // 
            this.gasPriceEntryTextBox.Location = new System.Drawing.Point(511, 170);
            this.gasPriceEntryTextBox.Name = "gasPriceEntryTextBox";
            this.gasPriceEntryTextBox.Size = new System.Drawing.Size(100, 20);
            this.gasPriceEntryTextBox.TabIndex = 47;
            this.gasPriceEntryTextBox.Visible = false;
            // 
            // electricityPriceEntryTextBox
            // 
            this.electricityPriceEntryTextBox.Location = new System.Drawing.Point(511, 143);
            this.electricityPriceEntryTextBox.Name = "electricityPriceEntryTextBox";
            this.electricityPriceEntryTextBox.Size = new System.Drawing.Size(100, 20);
            this.electricityPriceEntryTextBox.TabIndex = 48;
            this.electricityPriceEntryTextBox.Visible = false;
            // 
            // vehicleEfficiencyEntryTextBox
            // 
            this.vehicleEfficiencyEntryTextBox.Location = new System.Drawing.Point(511, 72);
            this.vehicleEfficiencyEntryTextBox.Name = "vehicleEfficiencyEntryTextBox";
            this.vehicleEfficiencyEntryTextBox.Size = new System.Drawing.Size(100, 20);
            this.vehicleEfficiencyEntryTextBox.TabIndex = 50;
            this.vehicleEfficiencyEntryTextBox.Visible = false;
            // 
            // serviceDollarsEntryBox
            // 
            this.serviceDollarsEntryBox.Location = new System.Drawing.Point(511, 40);
            this.serviceDollarsEntryBox.Name = "serviceDollarsEntryBox";
            this.serviceDollarsEntryBox.Size = new System.Drawing.Size(100, 20);
            this.serviceDollarsEntryBox.TabIndex = 51;
            this.serviceDollarsEntryBox.Visible = false;
            // 
            // dietDollarsEntryTextBox
            // 
            this.dietDollarsEntryTextBox.Location = new System.Drawing.Point(511, 13);
            this.dietDollarsEntryTextBox.Name = "dietDollarsEntryTextBox";
            this.dietDollarsEntryTextBox.Size = new System.Drawing.Size(100, 20);
            this.dietDollarsEntryTextBox.TabIndex = 52;
            this.dietDollarsEntryTextBox.Visible = false;
            // 
            // calcCarbonFootprintButton
            // 
            this.calcCarbonFootprintButton.Location = new System.Drawing.Point(333, 287);
            this.calcCarbonFootprintButton.Name = "calcCarbonFootprintButton";
            this.calcCarbonFootprintButton.Size = new System.Drawing.Size(100, 23);
            this.calcCarbonFootprintButton.TabIndex = 53;
            this.calcCarbonFootprintButton.Text = "Calculate Total";
            this.calcCarbonFootprintButton.UseVisualStyleBackColor = true;
            this.calcCarbonFootprintButton.Visible = false;
            this.calcCarbonFootprintButton.Click += new System.EventHandler(this.calcCarbonFootprintButton_Click);
            // 
            // vehicleEnterButton
            // 
            this.vehicleEnterButton.Location = new System.Drawing.Point(617, 69);
            this.vehicleEnterButton.Name = "vehicleEnterButton";
            this.vehicleEnterButton.Size = new System.Drawing.Size(75, 23);
            this.vehicleEnterButton.TabIndex = 56;
            this.vehicleEnterButton.Text = "Enter";
            this.vehicleEnterButton.UseVisualStyleBackColor = true;
            this.vehicleEnterButton.Visible = false;
            this.vehicleEnterButton.Click += new System.EventHandler(this.vehicleEnterButton_Click);
            // 
            // airEnterButton
            // 
            this.airEnterButton.Location = new System.Drawing.Point(405, 98);
            this.airEnterButton.Name = "airEnterButton";
            this.airEnterButton.Size = new System.Drawing.Size(75, 23);
            this.airEnterButton.TabIndex = 15;
            this.airEnterButton.Text = "Enter";
            this.airEnterButton.UseVisualStyleBackColor = true;
            this.airEnterButton.Visible = false;
            this.airEnterButton.Click += new System.EventHandler(this.airEnterButton_Click);
            // 
            // fuelFootprintTextBox
            // 
            this.fuelFootprintTextBox.Location = new System.Drawing.Point(710, 197);
            this.fuelFootprintTextBox.Name = "fuelFootprintTextBox";
            this.fuelFootprintTextBox.ReadOnly = true;
            this.fuelFootprintTextBox.Size = new System.Drawing.Size(100, 20);
            this.fuelFootprintTextBox.TabIndex = 57;
            this.fuelFootprintTextBox.Text = "Footprint: ";
            this.fuelFootprintTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.fuelFootprintTextBox.Visible = false;
            // 
            // airFootprintTextBox
            // 
            this.airFootprintTextBox.Location = new System.Drawing.Point(511, 102);
            this.airFootprintTextBox.Name = "airFootprintTextBox";
            this.airFootprintTextBox.ReadOnly = true;
            this.airFootprintTextBox.Size = new System.Drawing.Size(100, 20);
            this.airFootprintTextBox.TabIndex = 58;
            this.airFootprintTextBox.Text = "Footprint: ";
            this.airFootprintTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.airFootprintTextBox.Visible = false;
            // 
            // propaneFootprintTextBox
            // 
            this.propaneFootprintTextBox.Location = new System.Drawing.Point(710, 224);
            this.propaneFootprintTextBox.Name = "propaneFootprintTextBox";
            this.propaneFootprintTextBox.ReadOnly = true;
            this.propaneFootprintTextBox.Size = new System.Drawing.Size(100, 20);
            this.propaneFootprintTextBox.TabIndex = 59;
            this.propaneFootprintTextBox.Text = "Footprint: ";
            this.propaneFootprintTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.propaneFootprintTextBox.Visible = false;
            // 
            // gasFootprintTextBox
            // 
            this.gasFootprintTextBox.Location = new System.Drawing.Point(710, 170);
            this.gasFootprintTextBox.Name = "gasFootprintTextBox";
            this.gasFootprintTextBox.ReadOnly = true;
            this.gasFootprintTextBox.Size = new System.Drawing.Size(100, 20);
            this.gasFootprintTextBox.TabIndex = 60;
            this.gasFootprintTextBox.Text = "Footprint: ";
            this.gasFootprintTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gasFootprintTextBox.Visible = false;
            // 
            // electricityFootprintTextBox
            // 
            this.electricityFootprintTextBox.Location = new System.Drawing.Point(710, 143);
            this.electricityFootprintTextBox.Name = "electricityFootprintTextBox";
            this.electricityFootprintTextBox.ReadOnly = true;
            this.electricityFootprintTextBox.Size = new System.Drawing.Size(100, 20);
            this.electricityFootprintTextBox.TabIndex = 61;
            this.electricityFootprintTextBox.Text = "Footprint: ";
            this.electricityFootprintTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.electricityFootprintTextBox.Visible = false;
            // 
            // vehicleFootprintTextBox
            // 
            this.vehicleFootprintTextBox.Location = new System.Drawing.Point(710, 71);
            this.vehicleFootprintTextBox.Name = "vehicleFootprintTextBox";
            this.vehicleFootprintTextBox.ReadOnly = true;
            this.vehicleFootprintTextBox.Size = new System.Drawing.Size(100, 20);
            this.vehicleFootprintTextBox.TabIndex = 62;
            this.vehicleFootprintTextBox.Text = "Footprint: ";
            this.vehicleFootprintTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.vehicleFootprintTextBox.Visible = false;
            // 
            // serviceFootprintTextBox
            // 
            this.serviceFootprintTextBox.Location = new System.Drawing.Point(710, 39);
            this.serviceFootprintTextBox.Name = "serviceFootprintTextBox";
            this.serviceFootprintTextBox.ReadOnly = true;
            this.serviceFootprintTextBox.Size = new System.Drawing.Size(100, 20);
            this.serviceFootprintTextBox.TabIndex = 63;
            this.serviceFootprintTextBox.Text = "Footprint: ";
            this.serviceFootprintTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.serviceFootprintTextBox.Visible = false;
            // 
            // dietFootprintTextBox
            // 
            this.dietFootprintTextBox.Location = new System.Drawing.Point(710, 13);
            this.dietFootprintTextBox.Name = "dietFootprintTextBox";
            this.dietFootprintTextBox.ReadOnly = true;
            this.dietFootprintTextBox.Size = new System.Drawing.Size(100, 20);
            this.dietFootprintTextBox.TabIndex = 64;
            this.dietFootprintTextBox.Text = "Footprint: ";
            this.dietFootprintTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dietFootprintTextBox.Visible = false;
            // 
            // CarbonFootprintCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 396);
            this.Controls.Add(this.dietFootprintTextBox);
            this.Controls.Add(this.serviceFootprintTextBox);
            this.Controls.Add(this.vehicleFootprintTextBox);
            this.Controls.Add(this.electricityFootprintTextBox);
            this.Controls.Add(this.gasFootprintTextBox);
            this.Controls.Add(this.propaneFootprintTextBox);
            this.Controls.Add(this.airFootprintTextBox);
            this.Controls.Add(this.fuelFootprintTextBox);
            this.Controls.Add(this.vehicleEnterButton);
            this.Controls.Add(this.calcCarbonFootprintButton);
            this.Controls.Add(this.dietDollarsEntryTextBox);
            this.Controls.Add(this.serviceDollarsEntryBox);
            this.Controls.Add(this.vehicleEfficiencyEntryTextBox);
            this.Controls.Add(this.electricityPriceEntryTextBox);
            this.Controls.Add(this.gasPriceEntryTextBox);
            this.Controls.Add(this.fuelPriceEntryTextBox);
            this.Controls.Add(this.propanePriceEntryTextBox);
            this.Controls.Add(this.dietCategoriesEntryTextBox);
            this.Controls.Add(this.serviceCategoriesEntryTextBox);
            this.Controls.Add(this.vehicleMilesEntryTextBox);
            this.Controls.Add(this.airMilesEntryTextBox);
            this.Controls.Add(this.electricityBillEntryBox);
            this.Controls.Add(this.gasBillEntryTextBox);
            this.Controls.Add(this.fuelBillEntryTextBox);
            this.Controls.Add(this.propaneBillEntryTextBox);
            this.Controls.Add(this.dietEnterButton);
            this.Controls.Add(this.serviceEnterButton);
            this.Controls.Add(this.electricityEnterButton);
            this.Controls.Add(this.gasEnterButton);
            this.Controls.Add(this.fuelEnterButton);
            this.Controls.Add(this.propaneEnterButton);
            this.Controls.Add(this.propanePriceTextBox);
            this.Controls.Add(this.serviceDollarsTextBox);
            this.Controls.Add(this.vehicleEfficiencyTextBox);
            this.Controls.Add(this.electricityPriceTextBox);
            this.Controls.Add(this.gasPriceTextBox);
            this.Controls.Add(this.fuelPriceTextBox);
            this.Controls.Add(this.dietDollarsTextBox);
            this.Controls.Add(this.footprintTextbox);
            this.Controls.Add(this.airEnterButton);
            this.Controls.Add(this.propaneBillTextBox);
            this.Controls.Add(this.fuelBillTextBox);
            this.Controls.Add(this.gasBillTextBox);
            this.Controls.Add(this.electricityBillTextBox);
            this.Controls.Add(this.airMilesTextBox);
            this.Controls.Add(this.vehicleMilesTextBox);
            this.Controls.Add(this.serviceCategoriesTextBox);
            this.Controls.Add(this.dietCategoriesTextBox);
            this.Controls.Add(this.householdSubListBox);
            this.Controls.Add(this.transportationSubListBox);
            this.Controls.Add(this.emissionListBox);
            this.Name = "CarbonFootprintCalc";
            this.Text = "carbonFootprint";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox emissionListBox;
        private System.Windows.Forms.ListBox transportationSubListBox;
        private System.Windows.Forms.ListBox householdSubListBox;
        private System.Windows.Forms.TextBox dietCategoriesTextBox;
        private System.Windows.Forms.TextBox serviceCategoriesTextBox;
        private System.Windows.Forms.TextBox vehicleMilesTextBox;
        private System.Windows.Forms.TextBox airMilesTextBox;
        private System.Windows.Forms.TextBox electricityBillTextBox;
        private System.Windows.Forms.TextBox gasBillTextBox;
        private System.Windows.Forms.TextBox fuelBillTextBox;
        private System.Windows.Forms.TextBox propaneBillTextBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox footprintTextbox;
        private System.Windows.Forms.TextBox dietDollarsTextBox;
        private System.Windows.Forms.TextBox fuelPriceTextBox;
        private System.Windows.Forms.TextBox gasPriceTextBox;
        private System.Windows.Forms.TextBox electricityPriceTextBox;
        private System.Windows.Forms.TextBox vehicleEfficiencyTextBox;
        private System.Windows.Forms.TextBox serviceDollarsTextBox;
        private System.Windows.Forms.TextBox propanePriceTextBox;
        private System.Windows.Forms.Button propaneEnterButton;
        private System.Windows.Forms.Button fuelEnterButton;
        private System.Windows.Forms.Button gasEnterButton;
        private System.Windows.Forms.Button electricityEnterButton;
        private System.Windows.Forms.Button serviceEnterButton;
        private System.Windows.Forms.Button dietEnterButton;
        private System.Windows.Forms.TextBox propaneBillEntryTextBox;
        private System.Windows.Forms.TextBox fuelBillEntryTextBox;
        private System.Windows.Forms.TextBox gasBillEntryTextBox;
        private System.Windows.Forms.TextBox electricityBillEntryBox;
        private System.Windows.Forms.TextBox airMilesEntryTextBox;
        private System.Windows.Forms.TextBox vehicleMilesEntryTextBox;
        private System.Windows.Forms.TextBox serviceCategoriesEntryTextBox;
        private System.Windows.Forms.TextBox dietCategoriesEntryTextBox;
        private System.Windows.Forms.TextBox propanePriceEntryTextBox;
        private System.Windows.Forms.TextBox fuelPriceEntryTextBox;
        private System.Windows.Forms.TextBox gasPriceEntryTextBox;
        private System.Windows.Forms.TextBox electricityPriceEntryTextBox;
        private System.Windows.Forms.TextBox vehicleEfficiencyEntryTextBox;
        private System.Windows.Forms.TextBox serviceDollarsEntryBox;
        private System.Windows.Forms.TextBox dietDollarsEntryTextBox;
        private System.Windows.Forms.Button calcCarbonFootprintButton;
        private System.Windows.Forms.Button vehicleEnterButton;
        private System.Windows.Forms.Button airEnterButton;
        private System.Windows.Forms.TextBox fuelFootprintTextBox;
        private System.Windows.Forms.TextBox airFootprintTextBox;
        private System.Windows.Forms.TextBox propaneFootprintTextBox;
        private System.Windows.Forms.TextBox gasFootprintTextBox;
        private System.Windows.Forms.TextBox electricityFootprintTextBox;
        private System.Windows.Forms.TextBox vehicleFootprintTextBox;
        private System.Windows.Forms.TextBox serviceFootprintTextBox;
        private System.Windows.Forms.TextBox dietFootprintTextBox;
    }
}

