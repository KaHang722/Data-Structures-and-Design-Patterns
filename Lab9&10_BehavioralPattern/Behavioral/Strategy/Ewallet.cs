using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral.Strategy
{
    public class Ewallet: PaymentMode
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public Ewallet (string email, string password)
        {
            Email = email;
            Password = password;
        }

        public void Pay(int amt)
        {
            Console.WriteLine("Payment of $" + amt + " was made using E-wallet");
        }
    }
}
