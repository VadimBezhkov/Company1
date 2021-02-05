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

        public void PromoteAnEmployee(Employee emp, Position positRaise, double raiseAmmount)
        {
            bool isFound = false;

            if (emp.Position<4&&emp.Position>1)
            {
                emp.Position --;

                if (emp.Salary < SalaryDictionaty.ExecMinSal)
                    emp.Salary = SalaryDictionaty.ExecMinSal + SalaryDictionaty.Bonus;
            }


            if (!isFound)
                Console.WriteLine("Employee is not in company.");
        }

        public void DemoteEmployee(Employee emp, Position positRaise, double raiseAmmount)
        {
            bool isFound = false;

            if (emp.Position < 4 && emp.Position > 1)
            {
                emp.Position++;

                if (emp.Salary < SalaryDictionaty.ExecMinSal)
                    emp.Salary = SalaryDictionaty.ExecMinSal - SalaryDictionaty.Bonus;
            }


            if (!isFound)
                Console.WriteLine("Employee is not in company.");
        }
        public void Show()
        {
            foreach (var emp in Employees)
            {
                Console.WriteLine($"ID: {emp.Id} First Name{emp.FirstName} Last Name {emp.LastName} " +
                    $"Gender {(Gender)emp.Gender} Position {(Position)emp.Position}");
            }
}
    }
}
