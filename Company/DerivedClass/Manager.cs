using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    class Manager:Employee
    {
        public new decimal Salary { get; set; } = 2000m;
        public decimal Deductions { get; set; } = 135m;

        public Manager(int id, string lastname, string firstname, Gender gender, Position op) 
            : base(id, lastname, firstname,gender,op)
        {

        }
        public override decimal CalculationOfMmoney()
        {
            SalaryDictionaty.ExecMinSal = Salary-Deductions;
            return Salary;
        }
    }
}
