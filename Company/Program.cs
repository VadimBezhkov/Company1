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
            Executive ex = new Executive(20, "", "", Gender.man, Position.Manager);
            Console.WriteLine((Position)ex.Position);
            Console.ReadKey();
        }
    }
}
