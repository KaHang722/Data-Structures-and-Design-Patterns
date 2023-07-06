using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5_Structural_Patterns.Composite
{
    public class HeadDepartment : Department
    {
        private List<Department> departments = new List<Department>();

        public void addDepartment(Department d)
        {
            departments.Add(d);
        }

        public void removeDepartment(Department d)
        {
            departments.Remove(d);
        }

        public void GetDepartmentDetails()
        {
            departments.ForEach(d => d.GetDepartmentDetails());
        }
    }
}
