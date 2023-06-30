using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral.State
{
    public interface PackageStates
    {

        public void nextState(Package p);

        public void prevState(Package p);

        public void displayState(Package p);
    }
}
