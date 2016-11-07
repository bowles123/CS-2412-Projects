// CO2 emission from vehicles, a form of transportation.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    public class VehicleEmission : TransportationEmission
    {
        // Attributes.
        private double aveEfficiency;
        private double weekMiles;
        private const int NUM_WEEKS = 52;
        private const double POCEPG = 19.4;
        private const double EOGGOTC = 100 / 95;

        // Properties.
        public double WeekMiles
        {
            set
            {
                if (value >= 0)
                    weekMiles = value;
                else
                {
                    weekMiles = 0;
                    throw new ArgumentOutOfRangeException();
                }
            }

            get
            {
                return weekMiles;
            }
        }

        public double AveEfficiency
        {
            set
            {
                if (value > 0)
                    aveEfficiency = value;
                else
                {
                    aveEfficiency = 0;
                    throw new ArgumentOutOfRangeException();
                }
            }

            get
            {
                return aveEfficiency;
            }
        }

        // Explicit-value Constructor.
        public VehicleEmission(double miles, double effic)
        {
            WeekMiles = miles;
            AveEfficiency = effic;
        }

        // Calculate carbon footprint dure to vehicle emissions.
        public override double calcCarbonFootprint()
        {
            return ((WeekMiles * NUM_WEEKS) / AveEfficiency) * POCEPG * EOGGOTC;
        }
    }
}
