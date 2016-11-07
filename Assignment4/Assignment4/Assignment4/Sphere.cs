// Sphere class inhereting from the ThreeDimensialShape class.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    public class Sphere: ThreeDimensionalShape
    {
        public Sphere(double radius)
        {
            Circle = new Circle(radius);
        }

        public Circle Circle { set; get; }

        public override double getArea()
        {
            return 4.0 * Circle.getArea();
        }

        public override double getVolume()
        {
            return 4.0 / 3.0 * Circle.PI * Math.Pow(Circle.Radius, 3);
        }
    }
}
