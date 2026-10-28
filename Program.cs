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
            Console.WriteLine("3. Update Department");

            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine() ?? "0");

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter Department ID");
                    int departmentId = int.Parse(Console.ReadLine() ?? "0");

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
                case 3:
                    Console.Write("Enter Department ID to update: ");
                    int id = int.Parse(Console.ReadLine() ?? "0");
                    Console.Write("Enter New Department Name: ");
                    string newName = Console.ReadLine() ?? "";
                    Console.Write("Enter New Location: ");
                    string newLocation = Console.ReadLine() ?? "";
                    Console.Write("Is Active (true/false): ");
                    bool newIsActive = bool.Parse(Console.ReadLine() ?? "false");
                    service.UpdateDepartment(id, newName, newLocation, newIsActive);
                    break;

                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        }
    }
}