using System;
using System.Collections.Generic;
using System.Collections;

namespace DataStructures_Homework_1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Task_01();
            //Task_02();
            //Task_03();
            Task_04();

        }
        static void Task_01()
        {            
            float[] Array = new float[10];            
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Array [{i}] = ");
                Array[i] = Convert.ToInt32(Console.ReadLine());

            }
            foreach (int elem in Array)
            {
                Console.Write(elem);
            }
        }
        static void Task_02()
        {
            Stack<int> stack = new Stack<int>();
            Console.WriteLine("Push 10 items in the stack");
            for (int i = 0; i < 10; i++)
            {
                stack.Push(int.Parse(Console.ReadLine()));
            }
            while (stack.Count != 0)
            {
                Console.Write(stack.Pop() + " ");
            }        
        }
        static void Task_03()
        {
            Queue<int> Q = new Queue<int>();
            Console.WriteLine("Add 10 items in the queue");
            for (int i = 0; i < 10; i++)
            {
                Q.Enqueue(int.Parse(Console.ReadLine()));
            }
            foreach(int id in Q)
            {
                Console.Write(id+" ");
            }
        }
        static void Task_04()
        {
            List<int> list = new List<int>();
            Console.WriteLine("Add 10 items in the list");
            for (int i = 0; i < 10; i++)
            {
                list.Add(int.Parse(Console.ReadLine()));
            }
            foreach (int id in list)
            {
                Console.Write(id + " ");
            }
        }
    }
}
