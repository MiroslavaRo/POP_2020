using System;
using System.Collections.Generic;
using System.Text;

namespace POP_Class_work_lesson_6
{
    class Enums
    {
       
        public enum Make
        {
            Toyota,
            Ford,
            Renault,
            Peugeot,
            _null,
            other
                                 

        }

        public enum Model
        {
            Civic,
            Camry,
            Corolla,
            Focus,
            Escape,
            Megane,
            _406,
            _306,
            _null,
            other
        }

        public enum Color
        {
            Red = 1,
            Blue = 2,
            Yellow = 3,
            other = 4,
            _null
        }
        
    }
}
