using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment7
{
    public partial class calculatorForm : Form
    {
        decimal subTotal = 0M;
        decimal tax = 0M;
        decimal total = 0M;
        const double TAX_RATE = 0.07;
        int [] beverages = new int[6];
        int[] appetizers = new int[7];
        int[] entrées = new int[9];
        int[] desserts = new int[5];
        int beverage, appetizer, entrée, dessert;

        public calculatorForm()
        {
            InitializeComponent();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            enterButton.Visible = true;
            billTextBox.Text = "";
            billTextBox.Visible = false;
            subTotal = 0M;
            tax = 0M;
            total = 0M;
        }

        private void beverageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            beverageNumericUpDown.Visible = true;
            beverageNumericUpDown.Value = 1;
            
            if(beverageNumericUpDown.Value == 1)
                switch (beverageComboBox.SelectedIndex)
                {
                    case 0:
                        beverages[0] = 1;
                        break;
                    case 1:
                        beverages[1] = 1;
                        break;
                    case 2:
                        beverages[2] = 1;
                        break;
                    case 3:
                        beverages[3] = 1;
                        break;
                    case 4:
                        beverages[4] = 1;
                        break;
                    default:
                        beverages[5] = 1;
                        break;
                }

        }

        private void appetizerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            appetizerNumericUpDown.Visible = true;
            appetizerNumericUpDown.Value = 1;

            if (appetizerNumericUpDown.Value == 1)
                switch (appetizerComboBox.SelectedIndex)
                {
                    case 0:
                        appetizers[0] = 1;
                        break;
                    case 1:
                        appetizers[1] = 1;
                        break;
                    case 2:
                        appetizers[2] = 1;
                        break;
                    case 3:
                        appetizers[3] = 1;
                        break;
                    case 4:
                        appetizers[4] = 1;
                        break;
                    case 5:
                        appetizers[5] = 1;
                        break;
                    default:
                        appetizers[6] = 1;
                        break;
                }
        }

        private void dessertComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            dessertNumericUpDown.Visible = true;
            dessertNumericUpDown.Value = 1;

            if (dessertNumericUpDown.Value == 1)
                switch (dessertComboBox.SelectedIndex)
                {
                    case 0:
                        desserts[0] = 1;
                        break;
                    case 1:
                        desserts[1] = 1;
                        break;
                    case 2:
                        desserts[2] = 1;
                        break;
                    case 3:
                        desserts[3] = 1;
                        break;
                    default:
                        desserts[4] = 1;
                        break;
                }
        }

        private void entréeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            entréeNumericUpDown.Visible = true;
            entréeNumericUpDown.Value = 1;

            if (entréeNumericUpDown.Value == 1)
                switch (entréeComboBox.SelectedIndex)
                {
                    case 0:
                        entrées[0] = 1;
                        break;
                    case 1:
                        entrées[1] = 1;
                        break;
                    case 2:
                        entrées[2] = 1;
                        break;
                    case 3:
                        entrées[3] = 1;
                        break;
                    case 4:
                        entrées[4] = 1;
                        break;
                    case 5:
                        entrées[5] = 1;
                        break;
                    case 6:
                        entrées[6] = 1;
                        break;
                    case 7:
                        entrées[7] = 1;
                        break;
                    default:
                        entrées[8] = 1;
                        break;
                }
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            String text, subTotal_, tax_, total_;
            billTextBox.Visible = true;
            enterButton.Visible = false;

            subTotal = subTotal + (decimal) (beverages[0] * 1.95 + beverages[1] * 1.50 + beverages[2] * 1.25
                + beverages[3] * 2.95 + beverages[4] * 2.50 + beverages[5] * 1.50 + appetizers[0] * 5.95
                + appetizers[1] * 6.95 + appetizers[2] * 8.95 + appetizers[3] * 8.95 + appetizers[4] * 10.95
                + appetizers[5] * 12.95 + appetizers[6] * 6.95 + desserts[0] * 5.95 + desserts[1] * 3.95
                + desserts[2] * 5.95 + desserts[3] * 4.95 + desserts[4] * 5.95 + entrées[0] * 15.95
                + entrées[1] * 13.95 + entrées[2] * 13.95 + entrées[3] * 11.95 + entrées[4] * 19.95
                + entrées[5] * 20.95 + entrées[6] * 18.95 + entrées[7] * 13.95 + entrées[8] * 14.95);
            tax = subTotal * (decimal)TAX_RATE;
            total = subTotal + tax;

            subTotal_ = String.Format("{0,6:C}", subTotal);
            tax_ = String.Format("{0,6:C}", tax);
            total_ = String.Format("{0,6:C}", total);
            text = subTotal_ + "\r\nTax = " + tax_ + "\r\nTotal = " + total_;
            billTextBox.Text += text;
        }

        private void beverageNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            beverage = (int)beverageNumericUpDown.Value;

            switch (beverageComboBox.SelectedIndex)
            {
                case 0:
                    beverages[0] = beverage;
                    break;
                case 1:
                    beverages[1] = beverage;
                    break;
                case 2:
                    beverages[2] = beverage;
                    break;
                case 3:
                    beverages[3] = beverage;
                    break;
                case 4:
                    beverages[4] = beverage;
                    break;
                default:
                    beverages[5] = beverage;
                    break;
            }
        }

        private void appetizerNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            appetizer = (int)appetizerNumericUpDown.Value;

            switch (appetizerComboBox.SelectedIndex)
            {
                case 0:
                    appetizers[0] = appetizer;
                    break;
                case 1:
                    appetizers[1] = appetizer;
                    break;
                case 2:
                    appetizers[2] = appetizer;
                    break;
                case 3:
                    appetizers[3] = appetizer;
                    break;
                case 4:
                    appetizers[4] = appetizer;
                    break;
                case 5:
                    appetizers[5] = appetizer;
                    break;
                default:
                    appetizers[6] = appetizer;
                    break;
            }
        }

        private void dessertNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            dessert = (int)dessertNumericUpDown.Value;

            switch (dessertComboBox.SelectedIndex)
            {
                case 0:
                    desserts[0] = dessert;
                    break;
                case 1:
                    desserts[1] = dessert;
                    break;
                case 2:
                    desserts[2] = dessert;
                    break;
                case 3:
                    desserts[3] = dessert;
                    break;
                default:
                    desserts[4] = dessert;
                    break;
            }
        }

        private void entréeNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            entrée = (int)entréeNumericUpDown.Value;

            switch (entréeComboBox.SelectedIndex)
            {
                case 0:
                    entrées[0] = entrée;
                    break;
                case 1:
                    entrées[1] = entrée;
                    break;
                case 2:
                    entrées[2] = entrée;
                    break;
                case 3:
                    entrées[3] = entrée;
                    break;
                case 4:
                    entrées[4] = entrée;
                    break;
                case 5:
                    entrées[5] = entrée;
                    break;
                case 6:
                    entrées[6] = entrée;
                    break;
                case 7:
                    entrées[7] = entrée;
                    break;
                default:
                    entrées[8] = entrée;
                    break;
            }
        }
    }
}
