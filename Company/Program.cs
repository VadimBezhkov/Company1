using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Manager";

            var emp = (Employee)Activator.CreateInstance(Assembly.GetExecutingAssembly().FullName, str).Unwrap();
            Console.ReadKey();
        }
    }
}
