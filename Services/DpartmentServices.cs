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
    }
}