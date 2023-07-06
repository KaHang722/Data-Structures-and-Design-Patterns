using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5_Structural_Patterns.Composite
{
    public class Sales : Department
    {
        public int DeptID { get; set; }
        public string DeptName { get; set; }

        public Sales(int deptID, string deptName)
        {
            DeptID = deptID;
            DeptName = deptName;
        }

        public void GetDepartmentDetails()
        {
            Console.WriteLine("Department ID: " + DeptID + " Name: " + DeptName);
        }
    }
}
