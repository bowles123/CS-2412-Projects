// CO2 emission from household energy, abstract class.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    public abstract class HouseholdEnergyEmission : ICO2Emission
    {
        // Calculate carbon footprint due to household energy emission.
        // This is accomplished through the inheriting classes.
        public abstract double calcCarbonFootprint();
    }
}
