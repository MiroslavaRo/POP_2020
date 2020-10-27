using Microsoft.VisualBasic.CompilerServices;
using System;

namespace POP_Class_work_lesson_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //task_01();
            //task_02();
            task_03();
        }

        private static void task_01()
        {
            Dog mydog = new Dog("Rex", "Street Universal");            
            mydog.Bark();
            Console.WriteLine(mydog.Name);

        }

    
         private static void task_02()    
        {
            Person person1 = new Person("John Smith", 22, "jack@mail.com");
            Person person2 = new Person("Jack White", 20, "my@email");

            Console.WriteLine(person1.ToString());
            Console.WriteLine(person2.ToString());
        }

        private static void task_03()
        {
            Battery bt = new Battery("Li-lonn");
            Laptop lp = new Laptop("Lenovo Yoga 2 Pro", "Lenovo" , "Intel core 5i" , 8 ,"Intel HD Graphics 4400" , 128, "32000x1800", bt, 12, 1200);
            
            Console.WriteLine(lp.ToString());
        }



    }
}

