using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral.State
{
    public class Package
    {
        public PackageStates state;

        public Package()
        {
            state = new OrderedState();
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
