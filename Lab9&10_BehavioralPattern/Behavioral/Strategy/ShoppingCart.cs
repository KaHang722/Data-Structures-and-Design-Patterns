using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral.Strategy
{
    public class ShoppingCart
    {
        private List<Item> items = new List<Item>();

        public void AddItem (Item e)
        {
            items.Add(e);
        }

        public void RemoveItem (Item e)
        {
            items.Remove(e);
        }

        public void processPayment (PaymentMode paymentMode)
        {
            int total = 0;
            foreach (Item item in items)
            {
                total += item.Price;
            }
            paymentMode.Pay(total);
        }
    }
}
