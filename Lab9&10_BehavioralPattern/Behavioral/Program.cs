using Behavioral.State;
using Behavioral.Strategy;
using Behavioral.Template;
using System;

namespace Behaviroal // Note: actual namespace depends on the project name.
{
    public class Program
    {
        static void Main(string[] args)
        {
            //strategy design pattern
            Console.WriteLine("---------------------------------------Strategy---------------------------------------");
            ShoppingCart cart = new ShoppingCart();

            cart.AddItem(new Item("HDMI cable", 20));
            cart.AddItem(new Item("VGA cable", 10));

            cart.processPayment(new CreditCard("John", 1234, 000, "22-12-2022"));

            ShoppingCart cart2 = new ShoppingCart();
            cart2.AddItem(new Item("USB cable", 50));
            cart2.processPayment(new Ewallet("abc@gmail.com", "abc123"));

            //State design pattern
            Console.WriteLine("\n");
            Console.WriteLine("---------------------------------------State---------------------------------------");
            
            Package p = new Package();
            p.getState();

            p.setPrevState();

            p.setNextState();
            p.getState();

            p.setNextState();

            //Template design pattern
            Console.WriteLine("\n");
            Console.WriteLine("---------------------------------------Template---------------------------------------");

            Bake b1 = new Bread();
            Bake b2 = new Bagel();
            b1.BakeProduct();
            b2.BakeProduct();
        } 
    }
}