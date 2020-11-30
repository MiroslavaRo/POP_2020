using System.Collections.Generic;
using System.Linq;

namespace POP_Class_work_lesson_9
{
    public class Student
    {
        public Student()
        {
            Scores = new List<Score>();
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public List<Score> Scores { get; set; }

        public decimal AverageScore
        {
            get
            {
                return Scores.Average(s => s.Value); // Using Linq
            }
        }

        public string StudentNumber { get; set; }

        public override string ToString()
        {
            return $"Student: {StudentNumber,-10} {FirstName,-10} {LastName,-10} Average score = {AverageScore:0.00}";
        }
    }
}
