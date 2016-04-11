using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataManagement.Data;

namespace DataManagement.Components
{
   interface IEmployeeViewModel
   {
      IEmployee Employee { get; }
      bool IsSelected { get; set; }
   }
}
