using EmployeeLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example03
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Employee Peter = new Employee("Peter", "Lee");
            Peter.BaseSalary = 80000;
            Peter.Benifity = 500000;
            Console.WriteLine(Peter.Salary);
        }
    }
}