using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral.State
{
    public class OrderedState : PackageStates
    {
        public void displayState(Package p)
        {
            Console.WriteLine("Package is in Ordered State");
        }

        public void nextState(Package p)
        {
            p.state = new DeliveredState();
        }

        public void prevState(Package p)
        {
            Console.WriteLine("Package is already in its base state - Ordered State");
        }
    }
}
