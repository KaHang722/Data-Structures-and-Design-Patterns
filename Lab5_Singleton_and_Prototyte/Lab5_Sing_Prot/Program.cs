using System;

namespace Lab5_Sing_Prot // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool menucondition = true;

            while (menucondition)
            {
                Console.WriteLine("Choose an option");
                Console.WriteLine("1 - Demonstrate Singleton Pattern");
                Console.WriteLine("2 - Demonstrate Prototype Pattern");
                Console.WriteLine("3 - Exit");
                Console.WriteLine("Select an option!");

                switch (Console.ReadLine())
                {
                    case "1":
                        Singleton si1 = Singleton.getInstance();
                        Singleton si2 = Singleton.getInstance();

                        if (si1 == si2)
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
                        Student s1 = new Student();
                        s1.Name = "John";
                        s1.Department = "IT";

                        Console.WriteLine("Student s1- Name: " + s1.Name + " Department: " + s1.Department);
                        
                        Student s2 = (Student) s1.getClone();
                        Console.WriteLine("Student s2 (Before) - Name: " + s2.Name + " Department: " + s2.Department);

                        s2.Name = "Petar";
                        Console.WriteLine("Student s2 (After) - Name: " + s2.Name + " Department: " + s2.Department);

                        Student s3 = (Student) s2.getClone();
                        Console.WriteLine("Student s3 (Before) - Name: " + s3.Name + " Department: " + s3.Department);

                        Console.ReadLine();
                        break;

                    case "3":
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