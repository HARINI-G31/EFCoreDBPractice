using System;
using EFCorePractice.Services;

namespace EFCorePractice
{
    public class Program
    {
        static void Main(string[] args)
        {
            DepartmentService service = new DepartmentService();

            Console.Write("Enter Department Name: ");
            string name = Console.ReadLine() ?? "";

            Console.Write("Enter Location: ");
            string location = Console.ReadLine() ?? "";

            Console.Write("Is Active (true/false): ");
            bool isActive = bool.Parse(Console.ReadLine() ?? "false");

            service.AddDepartment(name, location, isActive);
        }
    }
}