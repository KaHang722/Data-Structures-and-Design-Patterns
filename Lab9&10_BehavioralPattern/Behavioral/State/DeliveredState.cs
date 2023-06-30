using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral.State
{
    public class DeliveredState : PackageStates
    {
        public void displayState(Package p)
        {
            Console.WriteLine("Package is in delivered state");
        }

        public void nextState(Package p)
        {
            Console.WriteLine("Package was already delivered and is in it's final state");
        }

        public void prevState(Package p)
        {
            p.state = new OrderedState(); 
        }
    }
}
