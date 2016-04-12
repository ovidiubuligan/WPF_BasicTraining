using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataManagement.Components.Dialogs
{
    interface IEditEmployeeViewModel
    {
        void Initialize(EditEmployeeDialog editEmployeeDialog, Data.IEmployee employee);
    }
}
