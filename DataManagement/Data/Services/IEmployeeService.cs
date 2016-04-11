using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManagement.Data.Services
{
   public interface IEmployeeService
   {
      List<IEmployee> GetAll();
   }
}
