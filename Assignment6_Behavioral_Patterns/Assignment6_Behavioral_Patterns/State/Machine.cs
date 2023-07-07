using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6_Behavioral_Patterns.State
{
    public class Machine
    {
        public MachineStates state;

        public Machine()
        {
            state = new StopState();
        }

        public void getState()
        {
            state.displayState(this);
        }

        public void setNextState()
        {
            state.nextState(this);
        }

        public void setPrevState()
        {
            state.prevState(this);
        }
    }
}
