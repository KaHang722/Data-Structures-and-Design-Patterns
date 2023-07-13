using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Project1
{
    internal class Faculty
    {
        public int FacultyID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Department { get; set; }

        public Faculty(int FacultyID, string FirstName, string LastName, string Gender, string Department)
        {
            this.FacultyID = FacultyID;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Gender = Gender;
            this.Department = Department;
        }

        public override string ToString()
        {
            return FacultyID + "|" + FirstName + "|" + LastName + "|" + Gender + "|" + Department;
        }
    }
}
