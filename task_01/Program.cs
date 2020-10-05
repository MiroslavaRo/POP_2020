using System;

namespace task_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //task_01();
            //task_02();
            //task_03();
            //task_04();
            //task_05();
            //task_06();
            //task_07();
            //task_08();
            //task_09();
            task_10();
        }
        static void task_01()
        {
            Console.WriteLine("Please, tape your name");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello,\n{name}");
        }
        static void task_02()
        {
            Console.WriteLine("Please, tape the first number");
            int A = int.Parse(Console.ReadLine());
            Console.WriteLine("Please, tape the second number");
            int B= int.Parse(Console.ReadLine());
            Console.WriteLine($"{A}+{B}={A+B}");

        }
        static void task_03()
        {
            double a =  14 + ((-4 * 6) / 11.0);
            double b = 2 + (15 / 6.0) - (7 % 2);            
            Console.WriteLine($"-1 + 4 * 6 = {(-1+(4*6))}\n(35 + 5) % 7 = {((35+5)%7)}  \n14 + -4 * 6 / 11 = {a}  \n2 + 15 / 6 * 1 - 7 % 2 = {b}");
        }
        static void task_04()
        {
            Console.WriteLine("Please, tape the first number");
            int A = int.Parse(Console.ReadLine());
            Console.WriteLine("Please, tape the second number");
            int B = int.Parse(Console.ReadLine());
            Console.WriteLine("Please, tape the third number");
            int C = int.Parse(Console.ReadLine());
            Console.WriteLine($"{A}*{B}*{C}={A * B * C}");
        }
        static void task_05()
        {
            Console.WriteLine("Please, tape the number");
            int A = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{A} * {i} = {A*i} \n");
            }
        }
        static void task_06()
        {
            Console.WriteLine("Please, tape the first number");
            int A = int.Parse(Console.ReadLine());
            Console.WriteLine("Please, tape the second number");
            int B = int.Parse(Console.ReadLine());
            Console.WriteLine("Please, tape the third number");
            int C = int.Parse(Console.ReadLine());
            Console.WriteLine("Please, tape the fourth number");
            int D = int.Parse(Console.ReadLine());
            Console.WriteLine($"Average = {(A + B + C + D)/4.0}");

        }
        static void task_07()
        {
            Console.WriteLine("Please, tape the number");
            int A = int.Parse(Console.ReadLine());
            if (A >= 100 && A <= 200)
            {
                Console.WriteLine("Given integer is within range between 100 and 200");
            }
            else
            {
                Console.WriteLine("Given integer isn't within range between 100 and 200");
            }
        }
        static void task_08()
        {
            DateTime date = DateTime.Now;
            Console.WriteLine(date.ToString("dd/MM/yyy"));

        }
        static void task_09() {
            Console.WriteLine("Please, tape your age: ");
            int A = int.Parse(Console.ReadLine());
            DateTime date = DateTime.Now;
            int dt = int.Parse(date.ToString("yyy"));
            int B = dt - A;
            Console.WriteLine($"Your year of birth is {B}");
        }
        static void task_10()
        {
            Console.WriteLine("Please, tape the X");
            int X = int.Parse(Console.ReadLine());
            Console.WriteLine("Please, tape the Y");
            int Y = int.Parse(Console.ReadLine());
            Console.WriteLine("Please, tape the Z");
            int Z = int.Parse(Console.ReadLine());
            Console.WriteLine($"(x+y)*z = {(X+Y)*Z}\t x*y + y*z = {(X*Y)+(Y*Z)}");

        }
    }
}
