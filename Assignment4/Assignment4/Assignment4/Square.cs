// Square class inhereting from the TwoDimensionalShape class.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    public class Square : TwoDimensionalShape
    {
        private double side;

        public Square(double side_) 
        {
            Side = side_;
        }

        public double Side
        {
            set
            {
                if (value >= 0)
                    side = value;
                else
                {
                    side = 0.0;
                    throw new ArgumentOutOfRangeException();
                }
            }

            get
            {
                return side;
            }
        }

        public override double getArea()
        {
            return Math.Pow(side, 2);
        }
    }
}
