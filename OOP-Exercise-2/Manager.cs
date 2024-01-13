using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exercise_2
{
    internal class Manager : Employee
    {
        private string _department;
        public Manager(string id, string department) : base(id)
        {
            Department = department;
        }
        public string Department { get; set; }

        public override void PrintDetails()
        {

            base.PrintDetails();
            Console.WriteLine($"Department: {Department}");
        }
    }
}
