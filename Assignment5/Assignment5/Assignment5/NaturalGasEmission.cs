// CO2 emission from natural gas, a form of household energy.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    public class NaturalGasEmission : HouseholdEnergyEmission
    {
        // Attributes.
        private double bill;
        private double cubicFeetPrice;
        private const double NGEF = 120.61;

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

        public double CubicFeetPrice
        {
            set
            {
                if (value > 0)
                    cubicFeetPrice = value;
                else
                {
                    cubicFeetPrice = 0;
                    throw new ArgumentOutOfRangeException();
                }
            }

            get
            {
                return cubicFeetPrice;
            }
        }

        // Explicit Value Constructor.
        public NaturalGasEmission(double bill, double price)
        {
            Bill = bill;
            CubicFeetPrice = price;
        }

        // Calculate carbon footprint due to natural gas emission.
        public override double calcCarbonFootprint()
        {
            return (Bill / CubicFeetPrice) * NGEF * 12;
        }
    }
}
