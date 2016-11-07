// Interface of CO2 emission.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    public interface ICO2Emission
    {
        // Calculate carbon footprint due to CO2 emission.
        // This is accomplished through the inheriting classes.
        double calcCarbonFootprint();
    }
}
