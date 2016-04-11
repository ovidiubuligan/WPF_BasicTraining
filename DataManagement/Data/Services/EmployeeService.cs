using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManagement.Data.Services
{
   public class EmployeeService : IEmployeeService
   {
      private const int GeneratedEmployeesCound = 2000;
      
      private List<IEmployee> employees;

      public List<IEmployee> GetAll()
      {
         if (employees == null)
         {
            this.GenerateEmployees();
         }
         return this.employees;
      }

      private void GenerateEmployees()
      {
         this.employees = new List<IEmployee>();
         Random rand = new Random();
         for (int i = 1; i <= GeneratedEmployeesCound; i++)
         {
             var cardType = "Visa";
             if (rand.Next(1) == 0) cardType = "Mastercard";
             var creditCard = Factory.CreateCard("" + rand.Next(1000, 9999) + rand.Next(1000, 9999) + rand.Next(1000, 9999) + rand.Next(1000, 9999),
                cardType)
             ;

            this.employees.Add(Factory.CreateEmployee("Employee " + i, 
                                                      "Department " + (i % 10 + 1), 
                                                      rand.Next(2000, 150000), 
                                                      creditCard));
         }   
      }
   }
}
