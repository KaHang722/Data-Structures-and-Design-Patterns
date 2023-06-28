using StructuralPatterns.Adaptor;
using StructuralPatterns.Composite;
using StructuralPatterns.Decorator;
using System;

namespace StructuralPatterns // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Decorator Pattern
            Shape s1 = new Circle(); //a normal circle
            s1.Draw();
            Console.WriteLine("\n");
            
            Shape shape1 = new BorderShapeDecorator(new Circle()); //Circle with dotted border
            shape1.Draw();
            Console.WriteLine("\n");

            Shape s2 = new Rectangle(); //a normal rectangle
            s2.Draw();
            Console.WriteLine("\n");

            Shape shape2 = new BorderShapeDecorator(new Rectangle()); //Rectangle with a dotted border
            shape2.Draw();
            Console.WriteLine("\n");

            Console.WriteLine("-------------------------Composite Design Pattern----------------------------");

            //Composite Pattern
            OrgDirectory devDir =new OrgDirectory();
            devDir.addEmployee(new Developer(1, "ABC"));
            devDir.addEmployee(new Developer(2, "XYZ"));

            OrgDirectory mgrDir = new OrgDirectory();
            mgrDir.addEmployee(new Manager(10, "PQR"));
            mgrDir.addEmployee(new Manager(11, "HIJ"));

            OrgDirectory mainDir = new OrgDirectory();
            mainDir.addEmployee(devDir);
            mainDir.addEmployee(mgrDir);

            mainDir.DisplayEmployeeDetails();

            Console.WriteLine("-------------------------Adaptor Design Pattern------------------------------");

            //Adaptor Pattern
            WeightApp w = new WeightApp(11);
            Console.WriteLine(w.getWeight());
            Console.WriteLine("Weight in KG: ");
            WeightAppUk winKg = new WeightAppUk(w);
            Console.WriteLine(winKg.getWeight());

        }
    }
}