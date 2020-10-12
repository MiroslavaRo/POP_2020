using System;

namespace POP_Class_work_lesson_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //task01();
            //task02();
            //task03();
            task04();
            //task05();
        }
        static void task01()
        {
            Console.Write("Type side A of the triangle: ");
            int A = int.Parse(Console.ReadLine());
            Console.Write("Type side B of the triangle: ");
            int B = int.Parse(Console.ReadLine());
            Console.Write("Type side C of the triangle: ");
            int C = int.Parse(Console.ReadLine());
            int k = 0;
                 
                
            if (A == B)
            {
                if (A == C)
                {
                    Console.WriteLine("Sides A, B and c are equal");
                    k=3;
                }
                else
                {
                    Console.WriteLine("Sides A and B are equal");
                    k=2;
                }
            }
                       
            else
            {
                if (C == B && C != A)
                {
                    Console.WriteLine("Sides C and B are equal");
                    k=2;
                }
                else
                {
                    Console.WriteLine("There are no equal sides");
                }
            }
            Console.WriteLine("There are {0} equal sides", k);
        }
        static void task02()
        {
            int k = 0;
            int sum = 0;
            
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Enter number {i+1}");
                int number = int.Parse(Console.ReadLine());
                if (number <= 20 && number >= 10)
                {
                    k++;
                    sum += k + number; 
                }
            }
            Console.WriteLine($"Number of numbers between 10 and 20 is {k}\n Sum of this numbers = {sum}");
           /* int n = 10;
            int[] array = new int[n];
            Console.WriteLine("Type 10 numbers");
            int k = 0;
            int sum = 0;           
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"array[{i+1}] = ");
                array[i] = Convert.ToInt32(Console.ReadLine());                

            }
            /*k++;
            sum += sum + elem;
            Console.WriteLine(elem);
            Console.WriteLine($"Number of numbers between 10 and 20 is {k}\n Sum of this numbers = {sum}");*/


            Console.ReadKey();
        }
        static void task03()
        {
            Console.Write("Please write your height : ");
            int a = int.Parse(Console.ReadLine());
            if (a >=175&&a<= 190) 
            {
                Console.WriteLine("Athletics");
            }
            if (a > 190)
            {
                Console.WriteLine("Basketball");
            }
            else
            {
                Console.WriteLine("Horse riding");
            }


        }
        static void task04()
        {
            Console.Write("Please, type day of the week (1-7): ");
            int day = int.Parse(Console.ReadLine());
            Console.Write("Please, type time of the day (0-23): ");
            int time = int.Parse(Console.ReadLine());
            //string Day = "";
            //string s= "";
            string Time = "";
           
            if (time >= 0 && time <= 6)
            {
                Time = "night";
            }
            if(time > 6 && time <= 12)
            {
                Time = "morning";
            }
            if (time > 12 && time <= 18)
            {
                Time = "afternoon";
            }
            if (time > 18 && time <24)
            {
                Time = "evening";
            }
            if (time>24)
            {
                Time = "(time isn't determined)";
            }

             Console.Write($"Good {Time}, it is a lovely {GetDayOfWeek(day)} today. {GetDayPeriodToWeekend(day)}");


        }
        static string GetDayOfWeek(int day)
        {
            switch (day)
            {
                case 1:return"Monday";                                  
                case 2:return"Tuesday";                   
                case 4:return"Thursday";                
                case 5:return"Friday";                    
                case 6:return"Saturday";                  
                case 7:return"Sunday";                   
                default:return "(the day isn't determined)";
            }
        }
        static string GetDayPeriodToWeekend(int day)
        {
            switch (day)
            {
                case 1: 
                case 2: 
                case 4: 
                case 5: 
                    return $"Weekend is coming in {6-day} days.";
                case 6: 
                case 7: 
                    return "Weekend is here!";
                default:
                    return "(the period of the day isn't determined)";
            }
        }
        static void task05()
        {
            Console.Write("Please, type your first name ");
            int Fd = int.Parse(Console.ReadLine());
            Console.Write("Please, type your last name ");
            int Ld = int.Parse(Console.ReadLine());
            Console.Write("Please, type your date of birth ");
            int Bd = int.Parse(Console.ReadLine());
            Console.Write("Please, type your last name ");
            int Sn = int.Parse(Console.ReadLine());


        }

    }
}
