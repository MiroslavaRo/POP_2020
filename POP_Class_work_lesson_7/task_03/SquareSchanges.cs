using System;
using System.Collections.Generic;
using System.Text;

namespace POP_Class_work_lesson_8.task_03
{
    public class SquareSchanges 
    {

        public double MoveX()
        {
            Console.WriteLine("Enter a new value of X coordinate: ");
            while (true)
            {
                bool check = double.TryParse(Console.ReadLine(), out double newX);
                if (check)
                {
                    return newX;
                }
                else
                {
                    Console.WriteLine("Wrong format");
                    continue;
                }

            }
       }
        public double MoveY()
        {
            Console.WriteLine("Enter a new value of Y coordinate: ");
            while (true)
            {
                bool check = double.TryParse(Console.ReadLine(), out double newY);
                if (check)
                {
                    return newY;
                }
                else
                {
                    Console.WriteLine("Wrong format");
                    continue;
                }

            }
        }

        public double Scale (double Side)
        {
            Console.WriteLine("Enter a factor to change side length: ");
            while (true)
            {
                bool check = double.TryParse(Console.ReadLine(), out double factor);
                if (check)
                {
                    double newSide = factor * Side;
                    return newSide;
                }
                else
                {
                    Console.WriteLine("Wrong format");
                    continue;
                }

            }
        }

        public double GetPerimeter (double side)
        {
            double perimeter = side * 4;
            return perimeter;             
        }
        public double GetArea (double side)
        {
            return side * side;
        }

    }
}
