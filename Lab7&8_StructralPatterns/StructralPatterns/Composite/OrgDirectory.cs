using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Composite
{
    public class OrgDirectory : Employee
    {
        private List<Employee> employees = new List<Employee>();
        
        public void addEmployee(Employee e)
        {
            employees.Add(e);
        }
        
        public void removeEmployee(Employee e)
        {
            employees.Remove(e);
        }

        public void DisplayEmployeeDetails()
        {
            employees.ForEach(e => e.DisplayEmployeeDetails() );
        }
    }
}
