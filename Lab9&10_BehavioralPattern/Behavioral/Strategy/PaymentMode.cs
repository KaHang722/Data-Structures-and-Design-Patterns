using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral.Strategy
{
    public interface PaymentMode
    {
        public void Pay(int amt);
    }
}
