using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exercise_2
{
    public class Employee
    {
        private string _id;
        public Employee(string Id)
        {
            EmployeeId = Id;

        }
        public string EmployeeId
        {
            get { return _id; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Id Cannot Be Empty.");

                }
                _id = value;
            }
        }
        public int Salary { get; private set; }
        public void setSalary(int salary)
        {
            if (salary < 0)
            {
                throw new Exception("Salary Cannot Be Negative");
            }
            Salary = salary;
        }
        public virtual void PrintDetails()
        {
            Console.WriteLine($"Employee Information:\n" +
                $"Id: {EmployeeId}\n" +
                $"Salary: {Salary}");
        }
    }
}
