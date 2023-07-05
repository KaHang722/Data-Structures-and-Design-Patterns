using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_Creational_patterns
{
    public sealed class Course
    {
        private Course() { }
        private static Course Instance;

        public static Course getInstance()
        {
            if (Instance == null)
            {
                Instance = new Course();
            }
            return Instance;
        }
    }
}
