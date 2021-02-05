﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    class Executive : Employee
    {
        public new decimal Salary { get; set; } = 5500m;
        public Executive(int id, string lastname, string firstname, Gender gender, Position op) 
            : base(id, lastname, firstname,gender,op)
        {
                
        }
    }
}
