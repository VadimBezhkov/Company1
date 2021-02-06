using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    class SalariedEmployee:Employee
    {
        public new decimal Salary { get; set; } = 1000m;
        public decimal Travel { get; set; } = 50m;
        public SalariedEmployee(int id, string lastname, string firstname, Gender gender, Position op) 
            : base(id, lastname, firstname,gender,op)
        {

        }
        public override decimal CalculationOfMmoney()
        {
            SalaryDictionary.ExecMinSal = Salary+Travel;
            return Salary;
        }
    }
}
