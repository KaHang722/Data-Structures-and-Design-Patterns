using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5_Structural_Patterns.Composite
{
    public class Finance : Department
    {
        public int DeptID { get; set; }
        public string DeptName { get; set; }

        public Finance(int deptId, string deptName)
        {
            DeptID = deptId;
            DeptName = deptName;
        }

        public void GetDepartmentDetails()
        {
            Console.WriteLine("Department ID: " + DeptID + " Name: " + DeptName);
        }
    }
}
