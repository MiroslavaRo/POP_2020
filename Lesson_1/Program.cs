using System;

namespace Lesson_1
{
    class Program
    {
        static void Main(string[] args)
        {
           // Circle();
             Console.WriteLine("Your age now is...");
            // int old = int.Parse(Console.ReadLine());
            string ageAsString = Console.ReadLine();
            int old = int.Parse(ageAsString);
            Console.WriteLine("After 10 years you will be {0} aged", old + 10);
            Console.ReadKey();
        }
        static void MeAfterTen()
        {
            Console.WriteLine("Please enter your age:");
            string ageAsString = Console.ReadLine();
            try
            {
                int ageAfterTen = int.Parse(ageAsString) + 10;
                Console.WriteLine("Your age after 10years will be " + ageAfterTen + " years");
                Console.WriteLine($"Your age after 10years will be {ageAfterTen} years");
            }
            catch
            {
                Console.WriteLine("Error!");
            }
        }
        static void MeAfterTen2()
        {
            Console.WriteLine("Please enter your age:");
            string ageAsString = Console.ReadLine();

            int.TryParse(ageAsString, out int ageAsInt);
            int ageAfterTen = ageAsInt + 10;
            //Console.WriteLine("Your age after 10years will be " + ageAfterTen + " years");
            Console.WriteLine($"Your age after 10years will be {ageAfterTen} years");


        }
        static void Rectangel()
        {
            Console.WriteLine("Please enter side A: ");
            int SideA = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter side B: ");
            int SideB = int.Parse(Console.ReadLine());

            Console.WriteLine("Area = " + SideA * SideB);
            Console.WriteLine("Perimeter = " + 2 * (SideA * SideB));
            Console.ReadKey();
        }
        static void Triangle()
        {

            Console.WriteLine("Please enter side A: ");
            double SideA = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter side B: ");
            double SideB = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter side C: ");
            double SideC = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter side High: ");
            double High = double.Parse(Console.ReadLine());

            Console.WriteLine("Area = " + (SideA * High) / 2);
            Console.WriteLine("Perimeter = " + (SideA + SideB + SideC));
            Console.ReadKey();
        }

        static void Circle()
        {
            Console.WriteLine("Please enter Radius: ");
            double R = double.Parse(Console.ReadLine());
            double a = Math.PI * Math.Pow(R, 2);
            double b = 2 * Math.PI * R;
            Console.WriteLine("Area = {0:f4}", a);
            Console.WriteLine("Circumference = {0:f4}", b);
            Console.ReadKey();

        }

        static void Task_3_Dates()
        {
            DateTime date = DateTime.Now;
            Console.WriteLine("Current date: ");
            Console.WriteLine(date.ToShortDateString());

            Console.WriteLine("Current time: ");
            Console.WriteLine(date.ToShortTimeString());

            Console.WriteLine("Date after 10 years: ");
            Console.WriteLine(date.AddYears(10).ToShortDateString());

            Console.WriteLine("Time after 10 years: ");
            Console.WriteLine(date.AddYears(10).ToShortTimeString());

            Console.WriteLine("Please enter a period");
            int period = int.Parse(Console.ReadLine());
            Console.WriteLine($"Date and time after {period} years: ");
            Console.WriteLine(date.AddYears(period).ToShortDateString()+"\n"+ date.AddYears(period).ToShortTimeString());
            Console.ReadKey();
        }
    }
}
