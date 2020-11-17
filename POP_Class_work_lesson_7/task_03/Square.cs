using System;
using System.Collections.Generic;
using System.Text;

namespace POP_Class_work_lesson_8
{
   public class Square
    { 
        public double x;
        public double y;
        public double side;

        public Square(double x, double y, double side) 
        { 
            this.x = x;
            this.y = y;
            this.side = side;
        }
        public double GetX()
        {
            return x;
        }
        public double GetY()
        {
            return y;
        }
        public double GetSide()
        {
            return side;
        }

        public override string ToString()
        {
            return $"Corner({x},{y}), side {side}";
        }
    }
}
