using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    class Company <T>
    {
        List<T> Employee = new List<T>();
        public string Nameconpany { get; set; }
        public void AddSalaried(SalariedEmployee employee)
        {

        }
    }
}
