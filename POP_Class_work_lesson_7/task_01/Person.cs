using System;
using System.Collections.Generic;
using System.Text;

namespace POP_Class_work_lesson_8.task_01
{
    public class Person
    {
        internal int age;

        public void SetAge(int age)
        {
            this.age = age;
        }

        public void Say(string message)
        {
            Console.WriteLine(message);
        }
    }
}
