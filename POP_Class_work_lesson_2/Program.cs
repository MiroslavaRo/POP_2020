using System;

namespace POP_Class_work_lesson_2
{
    class Program
    {
        static void Main(string[] args)
        {
            task01();
            //task02();
            //task03();
            //task04();
            //task05();
        }
        static void task01()
        {
            Console.Write("Print side A of the triangle: ");
            int A = int.Parse(Console.ReadLine());
            Console.Write("Print side B of the triangle: ");
            int B = int.Parse(Console.ReadLine());
            Console.Write("Print side C of the triangle: ");
            int C = int.Parse(Console.ReadLine());
                 
                
            if (A == B)
            {
                if (A == C)
                {
                    Console.WriteLine("Sides A, B and c are equal");
                }
                else
                {
                    Console.WriteLine("Sides A and B are equal");
                }
            }
                       
            else
            {
                if (C == B && C != A)
                {
                    Console.WriteLine("Sides C and B are equal");
                }
                else
                {
                    Console.WriteLine("There are no equal sides");
                }
            }
        }
        static void task02()
        {

        }
        static void task03()
        {

        }
        static void task04()
        {

        }
        static void task05()
        {

        }

    }
}
