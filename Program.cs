using System;
using EFCorePractice.Services;

namespace EFCorePractice
{
    public class Program
    {
        static void Main(string[] args)
        {
            DepartmentService service = new DepartmentService();

            Console.WriteLine("1. Add Department");
            Console.WriteLine("2. Display All Departments");

            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine() ?? "0");

            switch (choice)
            {
                case 1:
                    Console.Write("Enter Department Name: ");
                    string name = Console.ReadLine() ?? "";

                    Console.Write("Enter Location: ");
                    string location = Console.ReadLine() ?? "";

                    Console.Write("Is Active (true/false): ");
                    bool isActive = bool.Parse(Console.ReadLine() ?? "false");

                    service.AddDepartment(name, location, isActive);
                    break;

                case 2:
                    service.GetAllDepartments();
                    break;

                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        }
    }
}