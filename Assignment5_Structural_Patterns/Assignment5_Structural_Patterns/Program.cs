using Assignment5_Structural_Patterns.Adaptor;
using Assignment5_Structural_Patterns.Composite;
using Assignment5_Structural_Patterns.Decorator;
using System;

namespace Assignment5_Structural_Patterns // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool menucondition = true;

            while (menucondition)
            {
                Console.WriteLine("Choose an option");
                Console.WriteLine("1 - Decorator");
                Console.WriteLine("2 - Composite");
                Console.WriteLine("3 - Adaptor");
                Console.WriteLine("4 - Exit");
                Console.WriteLine("Select an option!");

                switch (Console.ReadLine())
                {
                    case "1":
                        Console.WriteLine("-------------------------Decorator Design Pattern------------------------------");
                        Player p1 = new Audio();
                        p1.Play();
                        Console.WriteLine("\n");

                        Player player1 = new BassEnhancer(new Audio());
                        player1.Play();
                        Console.WriteLine("\n");

                        Player p2 = new Video();
                        p2.Play();
                        Console.WriteLine("\n");

                        Player player2 = new BassEnhancer(new Video());
                        player2.Play();
                        Console.WriteLine("\n");

                        Console.ReadLine();
                        break;

                    case "2":
                        Console.WriteLine("-------------------------Composite Design Pattern------------------------------");
                        HeadDepartment salesDept = new HeadDepartment();
                        salesDept.addDepartment(new Sales(1, "Sales"));

                        HeadDepartment financeDept = new HeadDepartment();
                        financeDept.addDepartment(new Finance(2, "Finance"));

                        HeadDepartment dept = new HeadDepartment();
                        dept.addDepartment(salesDept);
                        dept.addDepartment(financeDept);

                        dept.GetDepartmentDetails();

                        Console.ReadLine();
                        break;

                    case "3":
                        Console.WriteLine("-------------------------Adaptor Design Pattern------------------------------");
                        SpeedApp s = new SpeedApp(50);
                        Console.WriteLine(s.getSpeed());
                        Console.WriteLine("Speed in KM: ");
                        SpeedAppUk sinKm = new SpeedAppUk(s);
                        Console.WriteLine(sinKm.getSpeed());

                        Console.ReadLine();
                        break;

                    case "4":
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