using System;
using EFCorePractice.Data;
using EFCorePractice.Models;

namespace EFCorePractice.Services
{
    public class DepartmentService
    {
        public void AddDepartment(string name, string location, bool isActive)
        {
            using (var context = new AppDbContext())
            {
                Department department = new Department
                {
                    DepartmentName = name,
                    Location = location,
                    IsActive = isActive
                };

                context.Departments.Add(department);
                context.SaveChanges();

                Console.WriteLine("Department added successfully!");
            }
        }
        public void GetAllDepartments()
        {
            using (var context = new AppDbContext())
            {
                List<Department> departments = context.Departments.ToList();

                foreach (Department department in departments)
                {
                    Console.WriteLine($"Department ID: {department.DepartmentId}");
                    Console.WriteLine($"Department Name: {department.DepartmentName}");
                    Console.WriteLine($"Location: {department.Location}");
                    Console.WriteLine($"Is Active: {department.IsActive}");
                    Console.WriteLine("--------------------------");
                }
            }
        }
    }
}