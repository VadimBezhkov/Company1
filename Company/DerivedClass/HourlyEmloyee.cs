using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    class HourlyEmloyee :Employee
    {
        public new decimal Salary { get; set; } = 10m;
        public int NumberOfHours { get; set; }
        public HourlyEmloyee(int id, string lastname, string firstname, Gender gender, Position op,int hour)
            : base(id, lastname, firstname,gender,op)
        {
            NumberOfHours = hour;
        }

        public  decimal CalculationOfMmoney(decimal salary,int hour)
        {
            Salary = salary * hour;
            return Salary;
        }
    }
}
