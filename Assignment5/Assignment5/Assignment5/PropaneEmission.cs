// CO2 emission from propane, a form of household energy.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    public class PropaneEmission : HouseholdEnergyEmission
    {
        // Attributes.
        private double bill;
        private double gallonPrice;
        private const double PEF = 12.17;

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

        public double GallonPrice
        {
            set
            {
                if (value > 0)
                    gallonPrice = value;
                else
                {
                    gallonPrice = 0;
                    throw new ArgumentOutOfRangeException();
                }
            }

            get
            {
                return gallonPrice;
            }
        }

        // Explicit-value Constructor.
        public PropaneEmission(double bill, double price)
        {
            Bill = bill;
            gallonPrice = price;
        }

        // Calculate carbon footprint due to propane emission.
        public override double calcCarbonFootprint()
        {
            return (Bill / gallonPrice) * PEF * 12;
        }
    }
}
