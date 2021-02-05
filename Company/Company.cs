using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    class Company
    {
        List<Employee> Employees = new List<Employee>();
        public string Nameconpany { get; set; }
        public void AddEmploee(Employee emp)
        {
            Employees.Add(emp);
        }
        public void DeleteEmploee(Employee emp)
        {
            Employees.Remove(emp);
        }
        public void ToRaise(Employee emp , Employee emp1)
        {
            bool isFound = false;
            for (int i = 0; i < Employees.Count; i++)
            {
                if (Employees[i] == emp)
                {
                    //emp1.FirstName = emp.FirstName;
                    //emp1.LastName = emp.LastName;
                    //emp1.Id = emp.Id;
                    Employees[i] = emp1;
                    isFound = true;
                    break;
                }
            }

            if(!isFound)
                Console.WriteLine("Employee is not in company.");
        }
        public void Show()
        {
            foreach (var emp in Employees)
            {
                Console.WriteLine(emp);
            }
        }
    }
}
