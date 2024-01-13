using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exercise_2
{
    public static class Office
    {
        private static List<Employee> employees = new();
        private static List<Manager> managers = new();

        public static void AddEmployee(string id, int salary)
        {
            var employee = new Employee(id);
            employee.setSalary(salary);
            employees.Add(employee);
        }
        public static void AddEmployee(string id, int salary, string department)
        {
            var manager = new Manager(id, department);
            manager.setSalary(salary);
            managers.Add(manager);
        }
        public static void ShowEmployees()
        {
            foreach (Employee employee in employees)
            {
                employee.PrintDetails();
                Console.WriteLine("-----------------");
            }


        }
        public static void ShowManagers()
        {
            foreach (Manager manager in managers)
            {
                manager.PrintDetails();
                Console.WriteLine("-----------------");
            }
        }

    }
}
