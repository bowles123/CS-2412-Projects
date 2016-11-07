// Tetrahedron class inheriting from the ThreeDimensialShape class.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    public class Tetrahedron: ThreeDimensionalShape
    {
        private double edge;

        public Tetrahedron(double e)
        {
            Edge = e;
        }

        public double Edge
        {
            set
            {
                if (value >= 0)
                    edge = value;
                else
                {
                    edge = 0.0;
                    throw new ArgumentOutOfRangeException();
                }
            }

            get
            {
                return edge;
            }
        }

        public override double getArea()
        {
            return Math.Sqrt(3.0) * Edge * Edge;
        }

        public override double getVolume()
        {
            return Math.Pow(Edge, 3) / (6.0 * Math.Sqrt(2.0));
        }
    }
}
