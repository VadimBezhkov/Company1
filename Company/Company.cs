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

        public void DeleteEmployee()
        {
            Console.WriteLine("Enter First Name");
            string name = Console.ReadLine();
            Employee employee = null;
            foreach (var empl in Employees)
            {

                if (empl.FirstName == name)
                {
                    employee = empl;
                }

                if (employee != null)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Thinking well ? - Enter key y");
                    Console.ResetColor();
                    string result = Console.ReadLine();
                    if (result == "y")
                    {
                        Employees.Remove(empl);
                        Console.Clear();
                        Show();
                        break;
                    }
                    else
                        break;
                }

                else
                {
                    Console.Clear();
                    Console.WriteLine("Employee not found");
                    Show();
                }
            }
        }

        public void PromoteAnEmployee(Employee emp, decimal bonus)
        {
            SalaryDictionaty.Bonus = bonus;

            if (emp.Position<4&&emp.Position>1)

            {
                emp.Position --;

                if (emp.Salary < SalaryDictionaty.ExecMinSal)
                    emp.Salary = SalaryDictionaty.ExecMinSal + SalaryDictionaty.Bonus;
            }


                Console.WriteLine("Employee is not in company.");
        }

        public void DemoteEmployee(Employee emp)
        {
            if (emp.Position < 4 && emp.Position >= 1)

            {
                emp.Position++;

                if (emp.Salary < SalaryDictionaty.ExecMinSal)
                    emp.Salary = SalaryDictionaty.ExecMinSal - SalaryDictionaty.Bonus;
            }

        }
        public void Show()
        {
            foreach (var emp in Employees)
            {
                Console.WriteLine($"ID: {emp.Id} First Name: {emp.FirstName} Last Name: {emp.LastName} " +
                    $"Gender: {(Gender)emp.Gender} Position: {(Position)emp.Position}");
            }
}
    }
}
