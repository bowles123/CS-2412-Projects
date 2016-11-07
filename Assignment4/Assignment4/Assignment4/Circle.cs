// Circle class inheriting from the TwoDimensionalShape class.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    public class Circle : TwoDimensionalShape
    {
        private double radius;
        public const double PI = 3.141592;

        public Circle(double rad)
        {
            Radius = rad;
        }

        public double Radius
        {
            set
            {
                if (value >= 0)
                    radius = value;
                else
                {
                    radius = 0.0;
                    throw new ArgumentOutOfRangeException();
                }
            }

            get
            {
                return radius;
            }
        }

        public override double getArea()
        {
            return PI * radius * radius;
        }

    }
}
