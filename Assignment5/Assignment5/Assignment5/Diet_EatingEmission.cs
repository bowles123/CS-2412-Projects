// CO2 emission from diet and eating habits.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    public class Diet_EatingEmission : ICO2Emission
    {
        // Attributes.
        private double totalDollars;
        private int numCategories;
        private const int TOTAL_FOOD_FACTOR = 6115;
        private const double GTPC = 0.0022;
        private const int MONTHS = 12;

        // Properties.
        public double TotalDollars
        {
            set
            {
                if (value > 0)
                    totalDollars = value;
                else
                {
                    totalDollars = 0;
                    throw new ArgumentOutOfRangeException();
                }
            }

            get
            {
                return totalDollars;
            }
        }

        public int NumCategories
        {
            set
            {
                if (value > 0)
                    numCategories = value;
                else
                {
                    numCategories = 0;
                    throw new ArgumentOutOfRangeException();
                }
            }

            get
            {
                return numCategories;
            }
        }

        // Explicit-value Constructor.
        public Diet_EatingEmission(double dollars, int categories)
        {
            TotalDollars = dollars;
            NumCategories = categories;
        }

        // Calculate carbon footprint due to diet and eating emission.
        public double calcCarbonFootprint()
        {
            return NumCategories * ((TotalDollars * TOTAL_FOOD_FACTOR * MONTHS) * GTPC);
        }
    }
}
