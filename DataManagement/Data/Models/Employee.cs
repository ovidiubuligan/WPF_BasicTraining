using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManagement.Data
{
   class Employee : IEmployee
   {
      public string Name { get; set; }
      public string Department { get; set; }
      public double Salary { get; set; }
      public ICreditCard Card { get; set; }
   }
}
