// CO2 emission from fuel oil, a form of household energy.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    public class FuelOilEmission : HouseholdEnergyEmission
    {
        // Attributes.
        private double bill;
        private double gallonPrice;
        private const double FOEF = 22.37;

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
        public FuelOilEmission(double bill, double price)
        {
            Bill = bill;
            GallonPrice = price;
        }

        // Calculate carbon footprint due to fuel oil emission.
        public override double calcCarbonFootprint()
        {
            return (Bill / GallonPrice) * FOEF * 12;
        }
    }
}
