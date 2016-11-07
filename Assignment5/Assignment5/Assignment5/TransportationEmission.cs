// CO2 emission from transportation, an abstract class.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    public abstract class TransportationEmission : ICO2Emission
    {
        // Calculate carbon footprint due to transportation emission
        // Two classes that inherit from this class accomplish that together.
        public abstract double calcCarbonFootprint();
    }
}
