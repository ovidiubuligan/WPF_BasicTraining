using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataManagement.Data;
using DataManagement.Utils;

namespace DataManagement.Components
{
   class ManagerViewModel : NotificationObject, IManagerViewModel
   {
      private List<IEmployeeViewModel> employees;

      public List<IEmployeeViewModel> FilteredEmployees
      {
         get
         {
            if (this.employees == null) 
            {
               return null;
            }
            return this.employees.Where(x => x.Employee != null 
                                             && (String.IsNullOrEmpty(this.filterName) || x.Employee.Name.IndexOf(this.filterName, StringComparison.OrdinalIgnoreCase) > -1)
                                             && (String.IsNullOrEmpty(this.filterDepartment) || x.Employee.Department.IndexOf(this.filterDepartment, StringComparison.OrdinalIgnoreCase) > -1)
                                             && (String.IsNullOrEmpty(this.filterSalary) || (x.Employee.Salary + "").IndexOf(this.filterSalary + "", StringComparison.OrdinalIgnoreCase) > -1)
                                             && (String.IsNullOrEmpty(this.filterCardNumber) || x.Employee.CardNumber.IndexOf(this.filterCardNumber, StringComparison.OrdinalIgnoreCase) > -1)
                                       ).ToList<IEmployeeViewModel>();
         }
      }

      private string filterName;
      public string FilterName
      {
         get
         {
            return this.filterName;
         }
         set
         {
            this.filterName = value;
            this.RaisePropertyChanged("FilteredEmployees");
         }
      }

      private string filterDepartment;
      public string FilterDepartment
      {
         get
         {
            return this.filterDepartment;
         }
         set
         {
            this.filterDepartment = value;
            this.RaisePropertyChanged("FilteredEmployees");
         }
      }

      private string filterSalary;
      public string FilterSalary
      {
         get
         {
            return this.filterSalary;
         }
         set
         {
            this.filterSalary = value;
            this.RaisePropertyChanged("FilteredEmployees");
         }
      }

      private string filterCardNumber;
      public string FilterCardNumber
      {
         get
         {
            return this.filterCardNumber;
         }
         set
         {
            this.filterCardNumber = value;
            this.RaisePropertyChanged("FilteredEmployees");
         }
      }

      public void Initialize()
      {
         this.employees = new List<IEmployeeViewModel>();
         foreach (IEmployee employee in Factory.GetEmployeeService().GetAll())
         {
            this.employees.Add(Factory.CreateEmployeeViewModel(employee)); 
         }
      }
   }
}
