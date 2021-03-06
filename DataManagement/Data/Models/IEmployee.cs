﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManagement.Data
{
    public interface IEmployee
   {
      string Name { get; set; }
      string Department { get; set; }
      double Salary { get; set; }
      ICreditCard Card { get; set; }
   }
}
