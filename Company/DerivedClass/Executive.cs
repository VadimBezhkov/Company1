using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    class Executive : Employee
    {
        public new decimal Salary { get; set; } = 500000m;
        public Executive(int id, string lastname, string firstname, int hour) : base(id, lastname, firstname, hour)
        {

        }
        public Executive(int id, string lastname, string firstname) : base(id, lastname, firstname)
        {
                
        }
        public override decimal CalculationOfMmoney()
        {
            PaymentOfTheMoney = (Salary / WorkingHoursPerMonth) * NumberOfHours;
            return PaymentOfTheMoney;
        }
    }
}
