using POP_Class_work_lesson_8.task_01;
using POP_Class_work_lesson_8.task_03;
using System;
namespace POP_Class_work_lesson_8
{
    class Program
    {
        static void Main(string[] args)
        {
           
            while (true)
            { 
                DisplayMenu();
                var choise = Console.ReadLine();
                if (choise == "4")
                {
                    break;
                }
                switch (choise)
                {
                    case "1":
                        StudentAndTeacherTest test = new StudentAndTeacherTest();
                        test.Main();
                        break;
                    case "2":
                        Console.WriteLine("Task 2 (PhotoAlbum)\n");
                        AlbumTest albumTest = new AlbumTest();
                        albumTest.Test();
                        break;
                    case "3":
                        Console.WriteLine("Task 3 (Square)\n--------------------");
                        SquareTester squerTest = new SquareTester();
                        squerTest.Test();
                        break;
                    default:
                        Console.WriteLine("Option dosen't available");
                        break;
                }

                EnterToContinue();
            }

        }
        private static void EnterToContinue()
        {
            Console.WriteLine("Press ENTER to continue");
            Console.ReadLine();
            Console.Clear();
        }
        private static void DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine("=========================");
            Console.WriteLine("1. Task 1");
            Console.WriteLine("2. Task 2 (PhotoAlbum)");
            Console.WriteLine("3. Task 3 (Square)");
            Console.WriteLine("4. Exit");
            Console.WriteLine("=========================");
            Console.Write("Please enter your choice: ");
        }
    }
}
