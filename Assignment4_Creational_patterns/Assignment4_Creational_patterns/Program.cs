using Assignment4_Creational_patterns.AbstractFactory;
using Assignment4_Creational_patterns.FactoryMethod;
using System;

namespace Assignment4_Creational_patterns // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool menucondition = true;

            while (menucondition)
            {
                Console.WriteLine("Choose an option");
                Console.WriteLine("1 - Singleton");
                Console.WriteLine("2 - Prototype");
                Console.WriteLine("3 - Factory Method ");
                Console.WriteLine("4 - Abstract Factory");
                Console.WriteLine("5 - Exit");
                Console.WriteLine("Select an option!");

                switch (Console.ReadLine())
                {
                    case "1":
                        Course c1 = Course.getInstance();
                        Course c2 = Course.getInstance();

                        if (c1 == c2)
                        {
                            Console.WriteLine("Singleton works!");
                        }
                        else
                        {
                            Console.WriteLine("Singleton fails!");
                        }

                        Console.ReadLine();
                        break;

                    case "2":
                        Employee e1 = new Employee();
                        e1.Name = "John";
                        e1.ID = 001;
                        e1.Address = "59 Hayden Street";

                        Console.WriteLine("Employee e1- Name: " + e1.Name + " ID: " + e1.ID + " Address: " + e1.Address);

                        Employee e2 = (Employee)e1.getClone();
                        Console.WriteLine("Employee e2 (Before) - Name: " + e2.Name + " ID: " + e2.ID + " Address: " + e2.Address);

                        e2.Name = "Petar";
                        e2.ID = 002;
                        e2.Address = "233 Younge Street";
                        Console.WriteLine("Employee e2 (After) - Name: " + e2.Name + " ID: " + e2.ID + " Address: " + e2.Address);

                        Employee e3 = (Employee)e2.getClone();
                        Console.WriteLine("Employee e3 (Before) - Name: " + e3.Name + " ID: " + e3.ID + " Address: " + e3.Address);

                        Console.ReadLine();
                        break;

                    case "3":
                        Recipe r1 = new Coffee_Recipe();
                        Recipe r2 = new IceCream_Recipe();

                        Console.WriteLine(r1.GetType().Name);
                        Console.WriteLine("-----------------------");
                        foreach (Ingredient ingredient in r1.Ingredients)
                        {
                            Console.WriteLine(ingredient.GetType().Name);
                        }
                        Console.WriteLine("-----------------------");
                        Console.WriteLine("-----------------------");

                        Console.WriteLine(r2.GetType().Name);
                        Console.WriteLine("-----------------------");
                        foreach (Ingredient ingredient in r2.Ingredients)
                        {
                            Console.WriteLine(ingredient.GetType().Name);
                        }
                        Console.ReadLine();
                        break;

                    case "4":
                        Client client1 = new Client(new StoreA());
                        client1.Compare();
                        Client client2 = new Client(new StoreB());
                        client2.Compare();
                        Console.ReadLine();
                        break;

                    case "5":
                        menucondition = false;
                        break;

                    default:
                        Console.ReadLine();
                        break;
                }
            }
        }
    }
}