using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    class SalariedEmployee:Employee
    {
        public new decimal Salary { get; set; } = 156000m;
        public SalariedEmployee(int id, string lastname, string firstname, int hour) : base(id, lastname, firstname, hour)
        {

        }
        public SalariedEmployee(int id, string lastname, string firstname) : base(id, lastname, firstname)
        {

        }
        public override decimal CalculationOfMmoney()
        {
            PaymentOfTheMoney = (Salary / WorkingHoursPerMonth) * NumberOfHours;
            return PaymentOfTheMoney;
        }
    }
}
