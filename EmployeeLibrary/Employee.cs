using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLibrary
{
    public class Employee
    {
        private string firdtName;
        private string secondName;
        private int baseSalary;

        private int benifity;
        private int salary;

        public string FirstName
        {
            get { return this.firdtName; }
            set { this.firdtName = value; }
        }

        public string SecondName
        {
            get { return secondName; }

            set { secondName = value; }
        }

        public int BaseSalary
        {
            get { return baseSalary; }
            set { baseSalary = value; }
        }

        public int Benifity
        {
            get { return benifity; }
            set { benifity = value; }
        }

        public int Salary
        {
            get { return Benifity + BaseSalary; }
        }
    }
}