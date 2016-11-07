// Brian Bowles, Assignment 1, January 13, 2015.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    // Pythagorean Triangle class to define a pythagorean triangle.
    class Triangle
    {
        public int A_ { set; get; }
        public int B_ { set; get; }
        public int C_ { set; get; }


        // Returns true if the triple is a pythagorean triple.
        public bool isPythagoreanTriple ()
        {
            bool isTriple = false;

            if (A_ * A_ + B_ * B_ == C_ * C_)
                isTriple = true;
            return isTriple;
        }
    }
}
