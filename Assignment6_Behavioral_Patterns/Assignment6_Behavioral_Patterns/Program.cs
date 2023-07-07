using Assignment6_Behavioral_Patterns.State;
using Assignment6_Behavioral_Patterns.Template;
using System;
using System.Numerics;
using System.Reflection.Emit;
using System.Threading;

namespace Assignment6_Behavioral_Patterns.Strategy // Note: actual namespace depends on the project name.
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool menucondition = true;

            while (menucondition)
            {
                Console.WriteLine("Choose an option");
                Console.WriteLine("1 - State");
                Console.WriteLine("2 - Template");
                Console.WriteLine("3 - Exit");
                Console.WriteLine("Select an option!");

                switch (Console.ReadLine())
                {
                    case "1":
                        Console.WriteLine("---------------------------State--------------------------------");
                        Machine m = new Machine();
                        m.getState();

                        m.setPrevState();

                        m.setNextState();
                        m.getState();

                        m.setNextState();

                        Console.ReadLine();
                        break;

                    case "2":
                        Console.WriteLine("-------------------------Template------------------------------");
                        Manufacture m1 = new Car();
                        Manufacture m2 = new Truck();
                        m1.ManufactureProduct();
                        m2.ManufactureProduct();

                        Console.ReadLine();
                        break;

                    case "3":
                        menucondition = false;
                        break;

                    default:
                        Console.ReadLine();
                        break;
                        Console.WriteLine("\n");
                }
            }
        }
    }
}