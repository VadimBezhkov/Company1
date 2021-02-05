using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    class HourlyEmloyee :Employee
    {
        public new decimal Salary { get; set; } = 1560;
        public HourlyEmloyee(int id, string lastname, string firstname) : base(id, lastname, firstname)
        {

        }
        public HourlyEmloyee(int id, string lastname, string firstname, int hour) : base (id, lastname, firstname, hour)
        {

        }
        public override decimal CalculationOfMmoney()
        {
            PaymentOfTheMoney = Salary * NumberOfHours;
            return PaymentOfTheMoney;
        }
    }
}
