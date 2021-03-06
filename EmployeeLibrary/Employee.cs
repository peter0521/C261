﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLibrary
{
    public class Employee
    {
        private string firstName;
        private string secondName;
        private int baseSalary;

        private int benifity;

        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
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

        public Employee(string firstName, string secondName)
        {
            this.FirstName = firstName;
            this.secondName = secondName;
        }

        public Employee()
        {
            this.FirstName = "Peter";
            this.secondName = "Lee";
        }
    }
}