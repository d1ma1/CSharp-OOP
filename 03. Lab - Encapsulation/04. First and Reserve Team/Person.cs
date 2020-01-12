﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PersonsInfo
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        private decimal salary;

        public string FirstName
        {
            get { return firstName; }
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("First name cannot contain fewer than 3 symbols!");
                }
                firstName = value;
            }
        }


        public string LastName
        {
            get => lastName;
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Last name cannot contain fewer than 3 symbols!");
                }
                lastName = value;
            }
        }
        public int Age
        {
            get => age;
            set
            {
                //if (age <= 0)
                //{
                //    throw new ArgumentException("Age cannot be zero or a negative integer!");
                //}
                age = value;
            }
        }
        public decimal Salary
        {
            get => salary;
            set
            {
                //if (salary < 460)
                //{
                //    throw new ArgumentException("Salary cannot be less than 460 leva!");
                //}
                salary = value;
            }
        }

        public Person(string firstName, string lastName, int age, decimal salary)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Salary = salary;
        }

        public void IncreaseSalary(decimal percentage)
        {
            if (this.Age < 30)
            {
                Salary = (Salary * percentage / 100) / 2 + Salary;
            }
            else
            {
                Salary = Salary * percentage / 100 + Salary;
            }
        }
        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName} receives {this.Salary:F2} leva.";
        }
    }
}
