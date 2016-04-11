using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManagement.Data.Models
{
    public class CreditCard : ICreditCard
    {
      public string CardNumber { get; set; }
      public string CardType { get; set; }
    }
}
