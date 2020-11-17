using System;
using System.Collections.Generic;
using System.Text;

namespace POP_Class_work_lesson_5
{
    public class Battery
    {
        private string nameofbattery;
        private int numofcells;
        private int mAh;
        public Battery(string nameofbattery, int numofcells, int mAh)
        {
            Name= nameofbattery;
            Numofcells = numofcells;
            MAh = mAh;

        }
        public Battery(string nameofbattery)
        {
            this.nameofbattery = nameofbattery;
        }
        public string Name
        {
            get => nameofbattery;

            set
            {
                
                nameofbattery = value;
            }
        }
        public int Numofcells
        {
            get => numofcells;

            set
            {
                if (value<0)
                {
                    throw new ArgumentNullException("Battery cells can`t be empty!");
                }
                numofcells = value;
            }

        }
        public int MAh
        {
            get => mAh;

            set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException("Battery mAh can`t be empty!");
                }
                mAh = value;
            }

        }


        public override string ToString()
        {
            if(numofcells==0&& mAh == 0)
            {
                return $"Battery: {nameofbattery}";
            }
            else
            {
                return $"Battery: {nameofbattery}, {numofcells}-cells, {mAh} mAh";
            }
            
        }

    }
}
