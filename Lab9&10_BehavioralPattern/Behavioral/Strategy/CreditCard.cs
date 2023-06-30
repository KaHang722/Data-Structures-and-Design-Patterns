using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral.Strategy
{
    public class CreditCard : PaymentMode
    {
        public string HolderName { get; set; }
        public int CardNo { get; set; }
        public int Cvv { get; set; }
        public string DOE { get; set; }

        public CreditCard (string holderName, int cardNo, int cvv, string dOE)
        {
            HolderName = holderName;
            CardNo = cardNo;
            Cvv = cvv;
            DOE = dOE;
        }

        public void Pay(int amt)
        {
            Console.WriteLine("Payment of $" + amt + " was made using a Credit Card" );
        }
    }
}
