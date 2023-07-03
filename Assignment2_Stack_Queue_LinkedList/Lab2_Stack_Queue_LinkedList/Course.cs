using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Stack_Queue_LinkedList
{
    internal class Course
    {
        public Course(string courseName, int score)
        {

            CourseName = courseName;
            Score = score;
        }

        public override bool Equals(object obj)
        {
            Course objCourse = obj as Course;
            if (objCourse == null)
            {
                return false;
            }
            return objCourse.CourseName==this.CourseName && objCourse.Score==this.Score;
        }
        public string CourseName {get; set; }
        public int Score {get; set; }
    }
}
