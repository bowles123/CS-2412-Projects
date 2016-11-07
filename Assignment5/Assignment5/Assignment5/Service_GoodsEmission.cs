// CO2 emission from service and goods.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    public class Service_GoodsEmission : ICO2Emission
    {
        // Attributes.
        private double totalDollars;
        private int numCategories;
        private const int TOTAL_FOOD_FACTOR = 6115;
        private const double GTPC = 0.0022;
        private const int NUM_MONTHS = 12;

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
        public Service_GoodsEmission(double dollars, int categories)
        {
            TotalDollars = dollars;
            NumCategories = categories;
        }

        // Calculate carbon footprint due to service and goods emission.
        public double calcCarbonFootprint()
        {
            return NumCategories * ((TotalDollars * TOTAL_FOOD_FACTOR * NUM_MONTHS) * GTPC);
        }
    }
}
