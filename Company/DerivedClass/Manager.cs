using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    class Manager:Employee
    {
        public new decimal Salary { get; set; } = 300000m;
        public Manager(int id, string lastname, string firstname, int hour) : base(id, lastname, firstname, hour)
        {

        }
        public Manager(int id, string lastname, string firstname) : base(id, lastname, firstname)
        {

        }
        public override decimal CalculationOfMmoney()
        {
            PaymentOfTheMoney= (Salary / WorkingHoursPerMonth) * NumberOfHours;
            return PaymentOfTheMoney;
        }
    }
}
