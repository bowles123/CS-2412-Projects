// Triangle class inheriting from the TwoDimensionalShape class.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    public class Triangle : TwoDimensionalShape
    {
        private double base_;
        private double height;

        public Triangle(double b, double h)
        {
            Base_ = b;
            Height = h;
        }

        public double Base_
        {
            set
            {
                if (value >= 0)
                    base_ = value;
                else
                {
                    base_ = 0.0;
                    throw new ArgumentOutOfRangeException();
                }
            }

            get
            {
                return base_;
            }
        }

        public double Height
        {
            set
            {
                if (value >= 0)
                    height = value;
                else
                {
                    height = 0.0;
                    throw new ArgumentOutOfRangeException();
                }
            }

            get
            {
                return height;
            }
        }

        public override double getArea()
        {
            return 0.5 * Base_ * Height;
        }
    }
}
