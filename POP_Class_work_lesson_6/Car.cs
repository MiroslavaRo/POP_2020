using System;
using System.Collections.Generic;
using System.Text;
using static POP_Class_work_lesson_6.Enums;

namespace POP_Class_work_lesson_6
{
    class Car
    {
        private string colorName;
        private string makeName;
        private string modelName;

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
                    throw new ArgumentOutOfRangeException("Year must be between 1900 to 2050");
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
        public string MakeName
        {
            get
            {
                switch (Make)
                {
                    case Make.other:
                        return makeName;

                    default:
                        return Make.ToString();
                }
            }
            set
            {
                if (value.Length <= 10)
                {
                    makeName = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }
        public string ModelName
        {
            get
            {
                switch (Model)
                {
                    case Model.other:
                        return modelName;

                    default:
                        return Model.ToString();
                }
            }
            set
            {
                if (value.Length <= 10)
                {
                    modelName = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }
        public override string ToString()
        {
            return $"{MakeName} {ModelName} {ColorName} {RegistrationNumber}";
        }
    }
}
