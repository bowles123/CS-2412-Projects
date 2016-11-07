// ThreeDimensionalShape class extending the IShape interface.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    public abstract class ThreeDimensionalShape : IShape
    {
        public abstract double getArea();
        public abstract double getVolume();
    }
}
