using System;
using System.Collections.Generic;
using System.Text;
using static POP_Class_work_lesson_6.Enums;

namespace POP_Class_work_lesson_6
{
    class Car
    {
        private string colorName;

        private int year;

        public string RegistrationNumber { get; set; }

        public int Year
        {
            get
            {
                return year;
            }
            set
            {
                if (value >= 1900 && value <= 2050)
                {
                    year = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }

        public Make Make { get; set; }

        public Model Model { get; set; }

        public Color Color { get; set; }

        public string ColorName
        {
            get
            {
                switch (Color)
                {
                    case Color.other:
                        return colorName;

                    default:
                        return Color.ToString();
                }
            }
            set
            {
                if (value.Length <= 10)
                {
                    colorName = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }

        public override string ToString()
        {
            return $"{Make} {Model} {Color} {RegistrationNumber}";
        }
    }
}
