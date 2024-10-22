using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qst17
{
    class Employee
    {
        public int DepId { get; set; }
        public string Name { get; set; }
    }
    class Department
    {
        public int id { get; set; }
        public string Name { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var departments = new List<Department>()
            {
                new Department{ id = 1, Name="Abc"},
                new Department{id=2,Name="Bcd"}

            };
            var employees = new List<Employee>()
            {
                new Employee{DepId=1, Name="Kerrthana"},
                new Employee{DepId=2,Name = "Sreejith"}
            };
            var empWithDep = employees
                .Join(
                    departments,
                    e => e.DepId,
                    d => d.id,
                    (e, d) => new
                    {
                        EmployeeName = e.Name,
                        DepartmentName = d.Name
                    }
                );

            foreach (var emp in empWithDep)
            {
                Console.WriteLine($"Employee Name: {emp.EmployeeName}, Department Name: {emp.DepartmentName}");
            }
        }
    }
}