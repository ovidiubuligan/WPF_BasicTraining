using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using DataManagement.Data;

namespace DataManagement.Components.Dialogs
{
    /// <summary>
    /// Interaction logic for EditEmployeeDialog.xaml
    /// </summary>
    public partial class EditEmployeeDialog : Window
    {
        public EditEmployeeDialog(IEmployee employee)
        {
            InitializeComponent();
            IEditEmployeeViewModel viewModel = Factory.CreateEditEmployeeViewModel(employee);
            viewModel.Initialize(this, employee);
            this.DataContext = viewModel;

        }
    }
}
