// Calculate carbon footprint using the GUI and the carbon footprint heiarchy.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5
{
    public partial class CarbonFootprintCalc : Form
    {
        // Variables.
        const int NUM_EMISSION_CATEGORIES = 8;
        ICO2Emission[] emission = new ICO2Emission[NUM_EMISSION_CATEGORIES];
        double totalEmission;

        public CarbonFootprintCalc()
        {
            InitializeComponent();
        }

        private void transportationSubListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // If Air Travel Emission option was selected display the info for that category.
            if ((string)transportationSubListBox.SelectedItem == "Air Travel Emission")
            {
                airEnterButton.Visible = true;
                airMilesEntryTextBox.Visible = true;
                airMilesTextBox.Visible = true;
            }
            // If Vehicle Emission option was selected display the info for that category.
            else
            {
                vehicleEnterButton.Visible = true;
                vehicleEfficiencyEntryTextBox.Visible = true;
                vehicleEfficiencyTextBox.Visible = true;
                vehicleMilesEntryTextBox.Visible = true;
                vehicleMilesTextBox.Visible = true;
            }
        }

        private void emissionListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // If Transportation Emission option was selected display the two sub-categories.
            if ((string)emissionListBox.SelectedItem == "Transportation Emission")
                transportationSubListBox.Visible = true;
            else
                // If Household Energy Emission option was selected display the four sub-categories.
                if ((string)emissionListBox.SelectedItem == "Household Energy Emission")
                    householdSubListBox.Visible = true;
                else
                    // If Diet & Eating Emission option was selected display the info for that category.
                    if ((string)emissionListBox.SelectedItem == "Diet & Eating Habits Emission")
                    {
                        dietCategoriesEntryTextBox.Visible = true;
                        dietCategoriesTextBox.Visible = true;
                        dietEnterButton.Visible = true;
                        dietDollarsEntryTextBox.Visible = true;
                        dietDollarsTextBox.Visible = true;
                    }
                    // If Service & Goods Emission option was selected display the info for that category.
                    else
                    {
                        serviceCategoriesEntryTextBox.Visible = true;
                        serviceCategoriesTextBox.Visible = true;
                        serviceEnterButton.Visible = true;
                        serviceDollarsEntryBox.Visible = true;
                        serviceDollarsTextBox.Visible = true;
                    }
        }

        private void householdSubListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // If Electricity Emission option was selected display the info for that category.
            if ((string)householdSubListBox.SelectedItem == "Electricity Emission")
            {
                electricityBillEntryBox.Visible = true;
                electricityBillTextBox.Visible = true;
                electricityEnterButton.Visible = true;
                electricityPriceTextBox.Visible = true;
                electricityPriceEntryTextBox.Visible = true;
            }
            else
                // If Natural Gas Emission option was selected display the info for that category.
                if ((string)householdSubListBox.SelectedItem == "Natural Gas Emission")
                {
                    gasBillEntryTextBox.Visible = true;
                    gasBillTextBox.Visible = true;
                    gasEnterButton.Visible = true;
                    gasPriceEntryTextBox.Visible = true;
                    gasPriceTextBox.Visible = true;
                }
                else
                    // If Fuel Oil Emission option was selected display the info for that category.
                    if ((string)householdSubListBox.SelectedItem == "Propane Emission")
                    {
                        propaneBillEntryTextBox.Visible = true;
                        propaneBillTextBox.Visible = true;
                        propaneEnterButton.Visible = true;
                        propanePriceEntryTextBox.Visible = true;
                        propanePriceTextBox.Visible = true;
                    }
                    // If Propane Emission option was selected display the info for that category.
                    else
                    {
                        fuelBillEntryTextBox.Visible = true;
                        fuelBillTextBox.Visible = true;
                        fuelEnterButton.Visible = true;
                        fuelPriceEntryTextBox.Visible = true;
                        fuelPriceTextBox.Visible = true;
                    }
        }

        private void calcCarbonFootprintButton_Click(object sender, EventArgs e)
        {
            // Calculate the total carbon footprint and display.
            footprintTextbox.Text += String.Format("{0: 0.0000}", totalEmission);
            footprintTextbox.Visible = true;
        }

        private void dietEnterButton_Click(object sender, EventArgs e)
        {
            // Display calculate button.
            calcCarbonFootprintButton.Visible = true;

            // Local variable objects.
            String dollars = dietDollarsEntryTextBox.Text;
            String categories = dietCategoriesEntryTextBox.Text;

            // Initialize variables of VehicleEmission object with user's input
            // And calculate its contribution to the carbon footprint.
            emission[0] = new Diet_EatingEmission(Double.Parse(dollars), Convert.ToInt32(categories));
            totalEmission += emission[0].calcCarbonFootprint();

            // Display carbon footprint due to diet & eating habits emission.
            dietFootprintTextBox.Text += String.Format("{0: 0.0000}", emission[0].calcCarbonFootprint());
            dietFootprintTextBox.Visible = true;
        }

        private void serviceEnterButton_Click(object sender, EventArgs e)
        {
            // Display calculate button.
            calcCarbonFootprintButton.Visible = true;

            // Local variable objects.
            String dollars = serviceDollarsEntryBox.Text;
            String categories = serviceCategoriesEntryTextBox.Text;

            // Initialize variables of VehicleEmission object with user's input
            // And calculate its contribution to the carbon footprint.
            emission[1] = new Service_GoodsEmission(Double.Parse(dollars), Convert.ToInt32(categories));
            totalEmission += emission[1].calcCarbonFootprint();

            // Display carbon footprint due to service & goods emission.
            serviceFootprintTextBox.Text += String.Format("{0: 0.0000}", emission[1].calcCarbonFootprint());
            serviceFootprintTextBox.Visible = true;
        }

        private void vehicleEnterButton_Click(object sender, EventArgs e)
        {
            // Display calculate button.
            calcCarbonFootprintButton.Visible = true;

            // Local variable objects.
            String miles = vehicleMilesEntryTextBox.Text;
            String efficiency = vehicleEfficiencyEntryTextBox.Text;

            // Initialize variables of VehicleEmission object with user's input
            // And calculate its contribution to the carbon footprint.
            emission[2] = new VehicleEmission(Double.Parse(miles), Double.Parse(efficiency));
            totalEmission += emission[2].calcCarbonFootprint();

            // Display carbon footprint due to vehicle travel emission.
            vehicleFootprintTextBox.Text += String.Format("{0: 0.0000}", emission[2].calcCarbonFootprint());
            vehicleFootprintTextBox.Visible = true;
        }

        private void airEnterButton_Click(object sender, EventArgs e)
        {
            // Display calculate button.
            calcCarbonFootprintButton.Visible = true;

            // Local variable objects.
            String miles = airMilesEntryTextBox.Text;

            // Initialize variables of VehicleEmission object with user's input
            // And calculate its contribution to the carbon footprint.
            emission[3] = new AirTravelEmission(Double.Parse(miles));
            totalEmission += emission[3].calcCarbonFootprint();

            // Display carbon footprint due to air travel emission.
            airFootprintTextBox.Text += String.Format("{0: 0.0000}", emission[3].calcCarbonFootprint());
            airFootprintTextBox.Visible = true;
        }

        private void electricityEnterButton_Click(object sender, EventArgs e)
        {
            // Display calculate button.
            calcCarbonFootprintButton.Visible = true;

            // Local variable objects.
            String price = electricityPriceEntryTextBox.Text;
            String bill = electricityBillEntryBox.Text;

            // Initialize variables of VehicleEmission object with user's input
            // And calculate its contribution to the carbon footprint.
            emission[4] = new ElectricityEmission(Double.Parse(bill), Double.Parse(price));
            totalEmission += emission[4].calcCarbonFootprint();

            // Display carbon footprint due to electricity emission.
            electricityFootprintTextBox.Text += String.Format("{0: 0.0000}", emission[4].calcCarbonFootprint());
            electricityFootprintTextBox.Visible = true;
        }

        private void gasEnterButton_Click(object sender, EventArgs e)
        {
            // Display calculate button.
            calcCarbonFootprintButton.Visible = true;

            // Local variable objects.
            String price = gasPriceEntryTextBox.Text;
            String bill = gasBillEntryTextBox.Text;

            // Initialize variables of VehicleEmission object with user's input
            // And calculate its contribution to the carbon footprint.
            emission[5] = new NaturalGasEmission(Double.Parse(bill), Double.Parse(price));
            totalEmission += emission[5].calcCarbonFootprint();

            // Display carbon footprint due to natural gas emission.
            gasFootprintTextBox.Text += String.Format("{0: 0.0000}", emission[5].calcCarbonFootprint());
            gasFootprintTextBox.Visible = true;
        }

        private void fuelEnterButton_Click(object sender, EventArgs e)
        {
            // Display calculate button.
            calcCarbonFootprintButton.Visible = true;

            // Local variable objects.
            String price = fuelPriceEntryTextBox.Text;
            String bill = fuelBillEntryTextBox.Text;

            // Initialize variables of VehicleEmission object with user's input
            // And calculate its contribution to the carbon footprint.
            emission[6] = new FuelOilEmission(Double.Parse(bill), Double.Parse(price));
            totalEmission += emission[6].calcCarbonFootprint();

            // Display carbon footprint due to fuel oil emission.
            fuelFootprintTextBox.Text += String.Format("{0: 0.0000}", emission[6].calcCarbonFootprint());
            fuelFootprintTextBox.Visible = true;
        }

        private void propaneEnterButton_Click(object sender, EventArgs e)
        {
            // Display calculate button.
            calcCarbonFootprintButton.Visible = true;

            // Local variable objects.
            String price = propanePriceEntryTextBox.Text;
            String bill = propaneBillEntryTextBox.Text;

            // Initialize variables of VehicleEmission object with user's input
            // And calculate its contribution to the carbon footprint.
            emission[7] = new PropaneEmission(Double.Parse(bill), Double.Parse(price));
            totalEmission += emission[7].calcCarbonFootprint();

            // Display carbon footprint due to propane emission.
            propaneFootprintTextBox.Text += String.Format("{0: 0.0000}", emission[7].calcCarbonFootprint());
            propaneFootprintTextBox.Visible = true;
        }
    }
}
