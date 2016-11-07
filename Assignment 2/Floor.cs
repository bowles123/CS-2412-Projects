// Class that resembles the floor the turtle draws on.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Floor
    {
        // Private attributes.
        private const int SIZE = 20;
        private int penPosition;
        private Tuple<int, int> position;
        private char direction;
        private int[,] floor;

        // Constructor.
        public Floor(char direction_)
        {
            penPosition = 1;
            direction = direction_;
            position= Tuple.Create(0,0);
            floor = new int[SIZE, SIZE];
        }

        // Displays what the turtle drew on the screen.
        public  void display()
        {
            // Traverse through the array displaying a star wherever the pen was down.
            for (int i = 0; i < SIZE; i++)
            {
                for (int j = 0; j < SIZE; j++)
                {
                    if (floor[i, j] == 0)
                        Console.Write(' ');
                    else
                        Console.Write('*');
                    // Console.Write(' ');
                }

                Console.WriteLine();
            }
        }

        // Moves the turtle a specified number of spaces.
        public void move(int spaces)
        {
            int columnPosition = position.Item2, rowPosition = position.Item1;

            // Moves the turtle according to number of spaces and initial direction of turtle.
            switch (direction)
            {
                case 'R':
                    if (penPosition == 2)
                        for (int j = columnPosition; j < columnPosition + spaces; j++)
                            floor[rowPosition, j] = 1;
                    columnPosition = position.Item2 + spaces;
                    break;
                case 'L':
                    if (penPosition == 2)
                        for (int j = columnPosition; j >= columnPosition - spaces; j--)
                            floor[rowPosition, j] = 1;
                    columnPosition = position.Item2 - spaces;
                    break;
                case 'U':
                    if (penPosition == 2)
                        for (int i = rowPosition; i >= rowPosition - spaces; i--)
                            floor[i, columnPosition] = 1;
                    rowPosition = position.Item1 - spaces;
                    break;
                default:
                    if (penPosition == 2)
                        for (int i = rowPosition; i < rowPosition + spaces; i++)
                            floor[i, columnPosition] = 1;
                    rowPosition = position.Item1 + spaces;
                    break;
            }
            position = Tuple.Create(rowPosition, columnPosition);
        }

        // Changes the turtles direction, turns it right or left.
        public void changeDirection(char direc)
        {
            // Change direction of turtle according to new and initial directions of turtle.
            if (direc == 'R')
                switch(direction)
                {
                    case 'R':
                        direction = 'D';
                        break;
                    case 'L':
                        direction = 'U';
                        break;
                    case 'U':
                        direction = 'R';
                        break;
                    default:
                        direction = 'L';
                        break;
                }
            else
                switch (direction)
                {
                    case 'R':
                        direction = 'U';
                        break;
                    case 'L':
                        direction = 'D';
                        break;
                    case 'U':
                        direction = 'L';
                        break;
                    default:
                        direction = 'R';
                        break;
                }
        }

        // Changes the position of the pen.
        public void changePen_Position(int newPosition)
        {
            penPosition = newPosition;
        }

    }
}
