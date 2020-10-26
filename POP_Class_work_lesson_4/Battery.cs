using System;
using System.Collections.Generic;
using System.Text;

namespace POP_Class_work_lesson_4
{
    public class Battery
    {
        public string nameofbattery;
        
        public Battery(string nameofbattery)
        {
            Name = nameofbattery;
        }
        public string Name
        {
            get => nameofbattery;

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Battery can`t be empty!");
                }
                nameofbattery = value;
            }
        }

    }
}
