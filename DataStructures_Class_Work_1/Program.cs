using System;
using System.Collections;
using System.Collections.Generic;

namespace DataStructures_Class_Work_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Task_02();
        }
        static void Task_01()
        {
            string[] names = { "Kolya", "Petya", "Vitya", "Maria" };
            DateTime[] bdays = new DateTime[names.Length];
            bdays[0] = new DateTime(2000, 01, 02);
            bdays[1] = new DateTime(2001, 02, 02);
            bdays[2] = new DateTime(2002, 03, 02);
            bdays[3] = new DateTime(2003, 04, 02);

            Console.Write("Please select index 0-3: ");
            int Index = int.Parse(Console.ReadLine());
           // string periodOfMonth = GetPeriodOfMonth(bdays, Index);
            string monthName = GetNameOfMonth(bdays[Index].Month);
            int day = bdays[Index].Day;
            string periodOfMonth = "beggining";
            if (day > 10)
            {
                periodOfMonth="mid";
            }
            if (day > 20)
            {
                periodOfMonth = "end";
            }
            //string monthName = GetNameOfMonth(bdays[Index].Month);
            Console.WriteLine($"{names[Index]} was born in {periodOfMonth} of {monthName}");
        }
        static string GetNameOfMonth(int month)
        {
            if (month == 1) return "January";
            if (month == 2) return "Fabruary";
            if (month == 3) return "March";
            if (month == 4) return "April";
            return "Unknown";
        }
    //private string GetPeriodOfMonth(DateTime[], int index){}
        private static void Task_02()
        {
            //Input
            string sent = "Write a C# Sharp Programm to display the folowing pattern using the alphabet";
            //Program logic
            string[] words = sent.Split(" ");
            string longest = "";
            foreach(string word in words) {
                if (longest.Length < word.Length)
                {
                    longest = word;
                }
            }
            //Output
            Console.WriteLine("the longest word is "+ longest);
        } 
        private static void Task_03() { 
        string sen = "Display the folowing pattern using the alphabet.";
            string[] words = sen.Split(" ");
            Stack<string> stack = new Stack<string>();

            foreach(string word in words)
            {
                stack.Push(word);
            }
            while (stack.Count > 0)
            {
                Console.Write(stack.Pop() + " ");
            }
        }
    
    }

}
