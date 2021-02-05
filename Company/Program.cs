using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    enum Operation
    {
        HireAnemployee =1,
        FireAnEmployee,
        ToPromote,
        Demote,
        Show
    }
    class Program
    {
       static void Menu()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Hire an employee - enter key 1");
            Console.WriteLine("Fire an Employee - enter key 2");
            Console.WriteLine("To Promote - enter 3");
            Console.WriteLine("Demote - enter 4");
            Console.WriteLine("Show all workers - утеук 5");
            Console.ResetColor();

        }
        static void Main(string[] args)
        {
        
            Executive ex = new Executive(1, "TTTTT", "VVVVVV", Gender.man, Position.Executive);
            HourlyEmloyee he = new HourlyEmloyee(2, "Nikolay", "Sid", Gender.man, Position.HourlyEmloyee,30);
            HourlyEmloyee eh = new HourlyEmloyee(3, "Tatiana", "Turomsha", Gender.woman, Position.HourlyEmloyee,25);
            Manager mn = new Manager(4, "Sonya", "Nicked", Gender.man, Position.Manager);
            Manager nm = new Manager(5, "Victor", "Samali", Gender.man, Position.Manager);
            SalariedEmployee se = new SalariedEmployee(6, "Misha", "Kursha", Gender.man, Position.SalariedEmployee);
            SalariedEmployee es = new SalariedEmployee(7, "Katya", "Kotov", Gender.man, Position.SalariedEmployee);
            Company company = new Company();

            company.AddEmploee(ex);
            company.AddEmploee(he);
            company.AddEmploee(eh);
            company.AddEmploee(mn);
            company.AddEmploee(nm);
            company.AddEmploee(se);
            company.AddEmploee(es);

            company.DemoteEmployee(ex);

            company.Show();
            Console.WriteLine();
            Menu();
            Operation op;
            Enum.TryParse(Console.ReadLine(), out op);


            Console.ReadKey();
        }
    }
}
