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

        public void ToRaise(Employee emp , Posit positRaise, double raiseAmmount)
        {
            bool isFound = false;

            if ((int)emp.Posit < positRaise)
            {
                emp.Posit = positRaise;

                if(emp.Salary < SalaryDictionaty.ExecMinSal)
                    emp.Salary = SalaryDictionaty.ExecMinSal + Bonus
            }


            if(!isFound)
                Console.WriteLine("Employee is not in company.");
        }
        public void Show()
        {
            foreach (var emp in Employees)
            {
                Console.WriteLine($"ID: {emp.Id} First Name{emp.FirstName} Last Name {emp.LastName}");
            }
        }
    }
}
