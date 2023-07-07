using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6_Behavioral_Patterns.State
{
    public class StartState : MachineStates
    {
        public void displayState(Machine m)
        {
            Console.WriteLine("Machine is in Start state");
        }

        public void nextState(Machine m)
        {
            Console.WriteLine("Machine was already started and is in it's final state. You can go back to previous state(Stop State) to stop the machine");
        }

        public void prevState(Machine m)
        {
            m.state = new StopState();
        }
    }
}
