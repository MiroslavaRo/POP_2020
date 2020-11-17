using System;
using System.Collections.Generic;
using System.Text;

namespace POP_Class_work_lesson_8.task_03
{
    class SquareTester
    {
        public void Test()
        {
            SquareBasic basic = new SquareBasic();
            SquareSchanges acts = new SquareSchanges();
            var basicPerimeter = acts.GetPerimeter(basic.GetSide());
            var basicArea = acts.GetArea(basic.GetSide());
            Console.WriteLine($"Basic square: \nPerimeter = {basicPerimeter}\nArea = {basicArea}\nProperties:{DisplayCurrentProp(basic)}");
            Console.WriteLine("---------------------------");
            double newX = ChangeCordinateX(basic.GetX());
            double newY = ChangeCordinateY(basic.GetY());
            double newSide = ChangeCordinateSide(basic.GetSide());
            Square newSquare = new Square(newX, newY, newSide);
            var newPerimeter = acts.GetPerimeter(newSide);
            var newArea = acts.GetArea(newSide);
            Console.WriteLine($"\n---------------------------\nNew Square:\nPerimeter = {newPerimeter}\nArea = {newArea}\nAll Properties:{DisplayCurrentProp(newSquare)}");

        }
        private string DisplayCurrentProp(Square props)
        {
            return props.ToString();            

        }
        private double ChangeCordinateX(double x)
        {
            SquareSchanges changes = new SquareSchanges();
            x = changes.MoveX();
            return x;
        }
        private double ChangeCordinateY(double y)
        {
            SquareSchanges changes = new SquareSchanges();
            y = changes.MoveY();
            return y;
        }
        private double ChangeCordinateSide(double side)
        {
            SquareSchanges changes = new SquareSchanges();
            var side2 = changes.Scale(side);
            return side2;
        }
 
    }
}
