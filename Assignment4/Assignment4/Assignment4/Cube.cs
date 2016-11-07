// Cube class inheriting from the ThreeDimensionalShape class.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    public class Cube : ThreeDimensionalShape
    {
        public Cube (double side) 
        {
            Square = new Square(side);
        }

        public Square Square { set; get; }

        public override double getArea()
        {
            return 6.0 * Square.getArea();
        }

        public override double getVolume()
        {
            return Math.Pow(Square.Side, 3);
        }

    }
}
