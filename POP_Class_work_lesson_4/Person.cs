using System;
using System.Collections.Generic;
using System.Text;

namespace POP_Class_work_lesson_5
{
    public class Person
    {
        private string name;
        private int age;
        private string email;

        public Person(string name, int age, string email)
        {
            Name = name;
            Age = age;
            Email = email;

        }
        public Person(string name, int age) : this(name, age, "")
        {

        }

        public string Name
        {
            get=> name;
            
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name can`t be empty!");
                }
                name = value;
            }
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentNullException("Age can`t be this!");
                }
                age = value;
            }

        }

        public string Email {
            get=> email;

            set
            {
                if (value != null && !value.Contains("@"))
                {
                    throw new ArgumentException("Email must be null or contain '@'!");
                }
                email = value;

            }
        }
        public override string ToString()
        {
            return $"Person {Name}, age: {Age}, email: {Email}";
        }

    }
}
