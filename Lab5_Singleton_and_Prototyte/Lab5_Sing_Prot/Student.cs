using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_Sing_Prot
{
    public class Student : MemberPrototype
    {
        public string Name { get; set; }
        public string Department { get; set; }

        public override MemberPrototype getClone()
        {
            return this.MemberwiseClone() as MemberPrototype;
        }
    }
}
