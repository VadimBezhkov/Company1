using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    class SalariedEmployee:Employee
    {
        public new decimal Salary { get; set; } 

        public SalariedEmployee(int id, string lastname, string firstname, Gender gender, Position op) : base(id, lastname, firstname,gender,op)
        {

        }
        public  decimal CalculationOfMmoney()
        {
            return Salary;
        }
    }
}
