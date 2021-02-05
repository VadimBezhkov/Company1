using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    public class SalariedEmployee<T>:Employee<T>
    {
        public SalariedEmployee(T id, string lastname, string firstname, int hour) : base(id, lastname, firstname, hour)
        {

        }
        public SalariedEmployee(T id, string lastname, string firstname) : base(id, lastname, firstname)
        {

        }
        public override decimal RecievePayment(decimal salary, int hour)
        {
            return salary;
        }
        public void Show()
        {
           Console.WriteLine(GetType());
        }

    }
}
