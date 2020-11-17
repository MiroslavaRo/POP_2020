using System;
using System.Collections.Generic;
using System.Text;

namespace POP_Class_work_lesson_8.task_01
{
    public class Student : Person
    {
        public void GoToClasses()
        {
            Console.WriteLine("I’m going to class.");
        }

        public void ShowAge()
        {
            Console.WriteLine($"My age is {age} years old");
        }
    }
}
