// Assignment 4, Brian Bowles, February 04, 2015.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class ShapeTest
    {
        const int NUM_SHAPES = 6;
        static void Main(string[] args)
        {
            IShape[] shapes = new IShape[NUM_SHAPES];

            // Initialize shapes with the 6 concrete classes provided.
            shapes[0] = new Circle(2.2);
            shapes[1] = new Cube(3.6);
            shapes[2] = new Sphere(1.9);
            shapes[3] = new Square(4.3);
            shapes[4] = new Tetrahedron(2.5);
            shapes[5] = new Triangle(1.3, 2.7);

            // Call getArea methods polymorphically and display shapes attributes.
            foreach (var currentShape in shapes)
            {
                if (currentShape is Circle)
                {
                    Circle shape = currentShape as Circle;
                    Console.WriteLine("Circle:\n\tRadius: {0:N2}\n\tArea: {1:N2}", shape.Radius, shape.getArea());
                }

                if (currentShape is Cube)
                {
                    Cube shape = currentShape as Cube;
                    Console.WriteLine("Cube:\n\tSide: {0:N2}\n\tArea: {1:N2}", shape.Square.Side, shape.getArea());
                    Console.WriteLine("\tVolume: {0:N2}", shape.getVolume());
                }

                if (currentShape is Sphere)
                {
                    Sphere shape = currentShape as Sphere;
                    Console.WriteLine("Sphere:\n\tRadius: {0:N2}\n\tArea: {1:N2}", shape.Circle.Radius, shape.getArea());
                    Console.WriteLine("\tVolume: {0:N2}", shape.getVolume());
                }

                if (currentShape is Square)
                {
                    Square shape = currentShape as Square;
                    Console.WriteLine("Square:\n\tSide: {0:N2}\n\tArea: {1:N2}", shape.Side, shape.getArea());
                }

                if (currentShape is Tetrahedron)
                {
                    Tetrahedron shape = currentShape as Tetrahedron;
                    Console.WriteLine("Tetrahedron:\n\tEdge: {0:N2}\n\tArea: {1:N2}", shape.Edge, shape.getArea());
                    Console.WriteLine("\tVolume: {0:N2}", shape.getVolume());
                }

                if (currentShape is Triangle)
                {
                    Triangle shape = currentShape as Triangle;
                    Console.WriteLine("Triangle:\n\tBase: {0:N2}\n\tHeight: {1:N2}\n\tArea: {2:N2}", shape.Base_, shape.Height, shape.getArea());
                }
            }
        }
    }
}
