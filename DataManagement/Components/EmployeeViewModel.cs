using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataManagement.Data;
using DataManagement.Utils;

namespace DataManagement.Components
{
   class EmployeeViewModel : NotificationObject, IEmployeeViewModel
   {
      
      public EmployeeViewModel(IEmployee employee)
      {
         this.employee = employee;
      }

      private IEmployee employee;
      public IEmployee Employee
      {
         get 
         {
            return this.employee;
         }
      }

      private bool isSelected;
      public bool IsSelected
      {
         get
         {
            return this.isSelected;
         }
         set
         {
            this.SetProperty<bool>(ref this.isSelected, value);
         }
      }
   }
}
