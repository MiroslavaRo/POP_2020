using System;
using System.Collections.Generic;
using System.Text;

namespace POP_Class_work_lesson_8.task_01
{
    public class StudentAndTeacherTest
    {
        public void Main()
        {
            Person person = new Person();
            person.Say("Hello!!");

            Student student = new Student();
            student.SetAge(20);
            student.Say("Greeting!");
            student.GoToClasses();
            student.ShowAge();

            Teacher teacher = new Teacher();
            teacher.SetAge(30);
            teacher.Say("Hello");
            teacher.Explain();

            Console.ReadLine();
        }
    }
}
