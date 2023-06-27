using Lab6_FactoryM_AbstractF.AbstractFactory;
using Lab6_FactoryM_AbstractF.FactoryMethod;
using System;

namespace Lab6_FactoryM_AbstractF // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------Factory Method------------- \n");
            Document doc1 = new eBookDocument();
            Document doc2 = new SalesReportDocument();

            Console.WriteLine(doc1.GetType().Name);
            Console.WriteLine("-----------------------");
            foreach (Page page in doc1.Pages)
            {
                Console.WriteLine(page.GetType().Name);
            }

            Console.WriteLine(doc2.GetType().Name);
            Console.WriteLine("-----------------------");
            foreach (Page page in doc2.Pages)
            {
                Console.WriteLine(page.GetType().Name);
            }

            Console.WriteLine("\n ----------Abstract Factory------------- \n");
            Client c1 = new Client(new VehicleFactoryA());
            c1.Compare();
            Client c2 = new Client(new VehicleFactoryB());
            c2.Compare();
        }
    }
}