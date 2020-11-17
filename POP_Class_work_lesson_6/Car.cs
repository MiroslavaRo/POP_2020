using System;
using static POP_Class_work_lesson_7.Enums;

namespace POP_Class_work_lesson_7
{
    public class Car : IVehicle
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
            return $"{MakeName,-10} {ModelName,-10} {ColorName,-10} Year:{Year} Reg.No:{RegistrationNumber} ";
        }
    }
}
