using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6_Behavioral_Patterns.State
{
    public class StopState : MachineStates
    {
        public void displayState(Machine m)
        {
            Console.WriteLine("Machine is in Stop State");
        }

        public void nextState(Machine m)
        {
            m.state = new StartState();
        }

        public void prevState(Machine m)
        {
            Console.WriteLine("Machine is already in its base state - Stop State");
        }
    }
}
