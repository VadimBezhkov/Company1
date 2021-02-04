using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
   abstract class HourlyEmloyee
    {
       abstract public decimal RecievePayment(decimal salary, int hour);
    }
}
