using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    abstract class Employee <T>:HourlyEmloyee
    {
        public T Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public decimal Salary { get; set; }
        public int NumberOfHours { get; set; }
        public Employee(T id, string lastname, string firstname)
        {
            Id = id;
            LastName = lastname;
            FirstName = firstname;
        }
        public Employee(T id, string lastname, string firstname, int hour) :this (id,lastname,firstname)
        { 
            NumberOfHours = hour;
        }
    }
}
