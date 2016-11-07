// Brian Bowles, Assignment 2, 01/26/15.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{

    class Assignment2
    {
        static void Main(string[] args)
        {
            // Output the three examples of the turtle.
            Console.WriteLine("The first set of operations creates the following: ");
            turtle1();
            Console.WriteLine("The second set of operations creates the following: ");
            turtle2();
            Console.WriteLine("The third set of operations creates the following: ");
            turtle3();
        }

        // Turtle draws a 12x12 square.
        static void turtle1()
        {
            Floor floor1 = new Floor('R');

            floor1.changePen_Position(2);
            floor1.move(12);
            floor1.changeDirection('R');
            floor1.move(12);
            floor1.changeDirection('R');
            floor1.move(12);
            floor1.changeDirection('R');
            floor1.move(12);
            floor1.changePen_Position(1);
            floor1.display();
        }

        // Turtle draws a capital 'L'.
        static void turtle2()
        {
            Floor floor2 = new Floor('D');

            floor2.changePen_Position(2);
            floor2.move(15);
            floor2.changeDirection('L');
            floor2.move(10);
            floor2.changePen_Position(1);
            floor2.display();
        }

        // Turtle draws a lower case 'i'.
        static void turtle3()
        {
            Floor floor3 = new Floor('D');

            floor3.changePen_Position(2);
            floor3.move(1);
            floor3.changePen_Position(1);
            floor3.move(1);
            floor3.changePen_Position(2);
            floor3.move(7);
            floor3.changePen_Position(1);
            floor3.display();
        }
    }
}
