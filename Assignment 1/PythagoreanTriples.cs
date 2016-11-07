// Brian Bowles, Assignment 1, January 13, 2015.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    // This class finds all the pythagorean triples less than 500 in length.
    class PythagoreanTriples
    {
        // Maximum length of side to be found for the triple.
        const int MAX_LENGTH = 500;

        static void Main(string[] args)
        {
            // Variables.
            Triangle triple = new Triangle();
            int number = 0;

            Console.WriteLine("The pythagorean triples less than 500 are: ");

            // Find all a, b, c combinations that satisfy the pythagorean theorem and output them.
            for (int a = 1; a <= MAX_LENGTH; a++)
                for (int b = 1; b <= MAX_LENGTH; b++)
                    for (int c = 1; c <= MAX_LENGTH; c++)
                    {
                        triple.A_ = a;
                        triple.B_ = b;
                        triple.C_ = c;

                        // If the triple is a pythagorean triple display it.
                        if (triple.isPythagoreanTriple())
                        {
                            number++;
                            Console.Write("#{0}: ", number);
                            Console.WriteLine(triple.A_ + ", " + triple.B_ + ", " + triple.C_);
                        }
                    }
        }
    }
}
