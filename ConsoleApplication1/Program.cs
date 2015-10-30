using CarLibrary2.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Car car = new Car();
            car.SetName("name");

            int year = int.Parse(Console.ReadLine());
            car.Year = year;

            Console.WriteLine(car.GetYear());
        }
    }
}