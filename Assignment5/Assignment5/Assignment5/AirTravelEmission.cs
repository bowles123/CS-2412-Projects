// CO2 emission from air travel, a form of transportation.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    public class AirTravelEmission : TransportationEmission
    {
        // Attributes.
        private double airMiles;
        private const int AEPM = 223;
        private const double IWTPF = 1.2;
        private const double IARFF = 1.9;
        private const double GTPC = 0.0022;

        // Property
        public double AirMiles
        {
            set
            {
                if (value >= 0)
                    airMiles = value;
                else
                {
                    airMiles = 0;
                    throw new ArgumentOutOfRangeException();
                }
            }

            get
            {
                return airMiles;
            }
        }

        // Explicit-value Constructor.
        public AirTravelEmission(double miles)
        {
            AirMiles = miles;
        }

        // Calculate carbon footprint due to air travel.
        public override double calcCarbonFootprint()
        {
            return AirMiles * (AEPM * IWTPF * IARFF) * GTPC;
        }
    }
}
