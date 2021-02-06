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
            Console.WriteLine();
            Console.WriteLine("Hire an employee - enter key 1");
            Console.WriteLine("Fire an Employee - enter key 2");
            Console.WriteLine("To Promote - enter 3");
            Console.WriteLine("Demote - enter key 4");
            Console.ResetColor();
        }
        static void MenuPosition()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Select position!!!");
            Console.WriteLine("Executive - enter key 1");
            Console.WriteLine("Manager - enter key 2");
            Console.WriteLine("Salaried Employee - enter 3");
            Console.WriteLine("Hourly Employee - enter 4");
            Console.ResetColor();
        }
        static Company MyCollection()
        {
            Executive ex = new Executive(1, "TTTTT", "VVVVVV", Gender.man, Position.Executive);
            HourlyEmloyee he = new HourlyEmloyee(2, "Nikolay", "Sid", Gender.man, Position.HourlyEmloyee, 30);
            HourlyEmloyee eh = new HourlyEmloyee(3, "Tatiana", "Turomsha", Gender.woman, Position.HourlyEmloyee, 25);
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

            company.Show();
            return company;
        }
        static void Chose()
        {
            Console.Clear();
            Company company1 = MyCollection();
            Console.WriteLine("Enter Id");
            int id;
            bool result = int.TryParse(Console.ReadLine(), out id);

            Console.WriteLine("Enter Last Name");
            string lastName = Console.ReadLine();

            Console.WriteLine("Enter First Name");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter Gander - enter key man ant any key woman");
            string gender = Console.ReadLine();

            GenderInfo(gender);
            MenuPosition();

            Position pos;
            Enum.TryParse(Console.ReadLine(), out pos);

            switch (pos)
            {
                case Position.Executive:
                    {
                        Executive executive = new Executive(id, lastName, firstName, GenderInfo(gender),
                            Position.Executive);

                        company1.AddEmploee(executive);
                        company1.Show();
                    }
                    break;
                case Position.Manager:
                    {
                        Manager manager = new Manager(id, lastName, firstName, GenderInfo(gender), Position.Manager);
                        company1.AddEmploee(manager);
                        company1.Show();
                    }
                    break;
                case Position.HourlyEmloyee:
                    {
                        HourlyEmloyee hourlyEmp = new HourlyEmloyee(id, lastName, firstName, GenderInfo(gender),
                            Position.HourlyEmloyee, 0);

                        company1.AddEmploee(hourlyEmp);
                        company1.Show();
                    }
                    break;
                case Position.SalariedEmployee:
                    {
                        SalariedEmployee salasried = new SalariedEmployee(id, lastName, firstName, GenderInfo(gender),
                            Position.SalariedEmployee);

                        company1.AddEmploee(salasried);
                        company1.Show();
                    }
                    break;
                default:
                    {
                        Console.WriteLine("Mistake. Make your choice \n" +
               "press any button to continue");
                        Console.ReadKey();
                    }
                    break;
            }
        }
        public static Gender GenderInfo(string gend)
        {
            if (gend == "man")
                return Gender.man;
            else 
                return Gender.woman;
        }
        static void Main(string[] args)
        {
            Company companyName =MyCollection();

            while (true)
            {
                Menu();

                Operation op;
                Enum.TryParse(Console.ReadLine(), out op);
                switch (op)
                {
                    case Operation.HireAnemployee:
                        {
                            Chose();
                        }

                        break;
                    case Operation.FireAnEmployee:
                        {
                            Company employes = companyName;
                            employes.DeleteEmployee();
                        }

                        break;
                    case Operation.ToPromote:
                        {
                            Company employes = companyName;
                            Console.WriteLine("Enter Bonus");
                            decimal result;
                            decimal.TryParse(Console.ReadLine(), out result);
                            employes.PromoteAnEmployee(result);
                        }

                        break;
                    case Operation.Demote:
                        {
                            Company employes = companyName;
                            Console.WriteLine("Enter Bonus");
                            decimal result;
                            decimal.TryParse(Console.ReadLine(), out result);
                            employes.DemoteEmployee(result);
                        }

                        break;
                    default:
                        {
                            Console.WriteLine("Mistake. Make your choice \n" +
                                   "press any button to continue");
                            Console.ReadKey();
                        }
                        break;
                }
            }
        }
    }
}
