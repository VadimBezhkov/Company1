using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    class SolariesEmployee<T>:Employee<T>
    {
        public SolariesEmployee(T id, string lastname, string firstname, int hour) : base(id, lastname, firstname, hour)
        {

        }
        public SolariesEmployee(T id, string lastname, string firstname) : base(id, lastname, firstname)
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
