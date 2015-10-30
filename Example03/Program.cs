using EmployeeLibrary;
using MathLibrary;
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

            Employee OO = new Employee();

            Console.WriteLine(OO.FirstName);

            Vcetor 小名 = new Vcetor(3, 4);
            Vcetor b = new Vcetor(1, 1);

            //小名.add(b);

            Console.WriteLine("a = {0}, {1}", 小名.X, 小名.Y);

            小名.Minus(1, 1).Minus(1, 1).add(new Vcetor(5, 5));

            Console.WriteLine("小名; = {0}, {1}", 小名.X, 小名.Y);
        }
    }
}