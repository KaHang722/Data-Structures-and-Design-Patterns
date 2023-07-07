using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6_Behavioral_Patterns.State
{
    public interface MachineStates
    {
        public void nextState(Machine m);

        public void prevState(Machine m);

        public void displayState(Machine m);
    }
}
