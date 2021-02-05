using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    enum Position
    {


    }

    abstract class Employee
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public decimal Salary { get; set; }
        public int NumberOfHours { get; set; }
        public int WorkingHoursPerMonth { get; set; }
        public  decimal PaymentOfTheMoney { get; set; }
        public Employee(int id, string lastname, string firstname)
        {
            Id = id;
            LastName = lastname;
            FirstName = firstname;
        }
        public Employee(int id, string lastname, string firstname, int hour) :this (id,lastname,firstname)
        { 
            NumberOfHours = hour;
        }
        public abstract decimal CalculationOfMmoney();
    }
}
