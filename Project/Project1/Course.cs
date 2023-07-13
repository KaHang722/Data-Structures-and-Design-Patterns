using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    internal class Course
    {
        public string CourseName { get; set; }
        public string CourseCode { get; set; }
        public string CourseLocation { get; set; }
        public string CourseDay { get; set; }
        public int CourseTime { get; set; }

        public Course(string CourseName, string CourseCode, string CourseLocation, string CourseDay, int CourseTime)
        {
            this.CourseName = CourseName;
            this.CourseCode = CourseCode;
            this.CourseLocation = CourseLocation;
            this.CourseDay = CourseDay;
            this.CourseTime = CourseTime;
        }

        public override string ToString()
        {
            return CourseName + "|" + CourseCode + "|" + CourseLocation + "|" + CourseDay + "|" + CourseTime;
        }
    }
}
