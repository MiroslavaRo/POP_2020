using System;
using System.Collections.Generic;
using System.Text;

namespace POP_Class_work_lesson_7
{
    public interface IVehicle
    {
        string RegistrationNumber { get; set; }

        public int Year { get; set; }
    }
}
