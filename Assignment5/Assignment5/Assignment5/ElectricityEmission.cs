// CO2 emission from electricity, a form of household energy.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    public class ElectricityEmission : HouseholdEnergyEmission
    {
        // Attributes.
        private double bill;
        private double kwhPrice;
        private const double EEF = 1.37;

        // Properties.
        public double Bill
        {
            set
            {
                if (value >= 0)
                    bill = value;
                else
                {
                    bill = 0;
                    throw new ArgumentOutOfRangeException();
                }
            }

            get
            {
                return bill;
            }
        }

        public double KWHPrice
        {
            set
            {
                if (value > 0)
                    kwhPrice = value;
                else
                {
                    kwhPrice = 0;
                    throw new ArgumentOutOfRangeException();
                }
            }

            get
            {
                return kwhPrice;
            }
        }

        // Explicit-value Constructor.
        public ElectricityEmission(double bill, double price) 
        {
            Bill = bill;
            KWHPrice = price;
        }

        // Calculate carbon footprint due to electricity emission.
        public override double calcCarbonFootprint()
        {
            return (Bill / KWHPrice) * EEF * 12;
        }
    }
}
