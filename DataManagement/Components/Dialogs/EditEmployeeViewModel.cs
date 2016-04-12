using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataManagement.Data;

namespace DataManagement.Components.Dialogs
{
    class EditEmployeeViewModel : IEditEmployeeViewModel
    {
        public EditEmployeeViewModel(IEmployee employee)
        {
            
        }

        public void Initialize(EditEmployeeDialog editEmployeeDialog, IEmployee employee)
        {
        }
    }
}
