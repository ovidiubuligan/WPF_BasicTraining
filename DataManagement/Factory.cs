using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataManagement.Components;
using DataManagement.Data;
using DataManagement.Data.Models;
using DataManagement.Data.Services;

namespace DataManagement
{
   static class Factory
   {
      private static IEmployeeService employeeService;

      public static IEmployeeService GetEmployeeService()
      {
         if (employeeService == null)
         {
            employeeService = new EmployeeService();
         }
         return employeeService;
      }


       public static ICreditCard CreateCard(string cardNumber, string cardType)
       {
           return new CreditCard()
           {
               CardNumber = cardNumber,
               CardType = cardType
           };
       }

       public static IEmployee CreateEmployee(string name, string department, double salary, ICreditCard card) 
      {
         return new Employee()
         {
            Name = name,
            Department = department,
            Salary = salary,
            Card = card
         };
      }

      public static IEmployeeViewModel CreateEmployeeViewModel(IEmployee employee)
      {
         return new EmployeeViewModel(employee);
      }

      public static IManagerViewModel CreateManagerViewModel()
      {
         return new ManagerViewModel();
      }
   }
}
