using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManagement.Data
{
   interface IEmployee
   {
      string Name { get; set; }
      string Department { get; set; }
      double Salary { get; set; }
      string CardNumber { get; set; }
   }
}
