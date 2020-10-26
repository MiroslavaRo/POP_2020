using System;
using System.Collections.Generic;
using System.Text;

namespace POP_Class_work_lesson_4
{
   public class  Dog
    {
        private string name;
        public Dog(string name, string breed)
        {
            Name = name;
            Breed = breed;
            
        }
        public string Name
        {
            get { return name; }
            set
            {
                if (value == "")
                {
                    throw new Exception("Can must have name!!!");
                }
                name = value;
            }
        }
        public string Breed
        {
            get;
            set;
        }

        public void Bark()
        {
            Console.WriteLine("Woof!");
        }

    }
}
