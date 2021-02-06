using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    enum Position
    {
        Executive = 1,
        Manager,
        SalariedEmployee,
        HourlyEmloyee
        
    }
    enum Gender
    {
        man =1,
        woman
    }

    abstract class Employee
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public decimal Salary { get; set; }
        public int Gender { get; set; }
        public int Position { get; set; }


        public Employee(int id, string lastname, string firstname,Gender gender,Position op)
        {
            Id = id;
            LastName = lastname;
            FirstName = firstname;
            Gender = (int)gender;
            Position = (int)op;
        }
        public virtual decimal CalculationOfMmoney()
        {
            SalaryDictionaty.ExecMinSal = Salary;
            return Salary;
        }
    }
}
