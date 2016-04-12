using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using DataManagement.Data;
using DataManagement.Utils;

namespace DataManagement.Components.Dialogs
{
    class EditEmployeeViewModel : NotificationObject ,IEditEmployeeViewModel
    {
        private Window dialog;
        private IEmployee employee;

        public EditEmployeeViewModel()
        {
          this.saveCommand = new DelegateCommand(OnSave, CanSave);
          this.cancelCommand = new DelegateCommand(OnCancel);
        }

        private string name;
        public string Name
        {
             get
             {
                return this.name;
             }
             set
             {
                this.SetProperty<string>(ref name, value);
                this.saveCommand.RaiseCanExecuteChanged();
             }
        }

        public string Department { get; set; }
        public double Salary { get; set; }
        public string CardNumber { get; set; }

        private DelegateCommand saveCommand;
        public ICommand SaveCommand
        {
            get
            {
                return this.saveCommand;
            }
        }

        private DelegateCommand cancelCommand;
        public ICommand CancelCommand
        {
            get
            {
                return this.cancelCommand;
            }
        }


        public void Initialize(EditEmployeeDialog editEmployeeDialog, IEmployee employee)
        {
            this.dialog = editEmployeeDialog;
            this.employee = employee;

            // se default values for inputs
            this.Name = this.employee.Name;
            this.Department = this.employee.Department;
            this.Salary = this.employee.Salary;
            this.CardNumber = this.employee.Card.CardNumber;

            this.dialog.KeyDown += OnParentDlgKeyDown;

        }
        private void OnParentDlgKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
            {
                this.CloseDialog(false);
            }
            else if (e.Key == Key.Enter && this.CanSave(null))
            {
                this.Save();
            }
            else
            {
                // do nothing
            }
        }

        private void CloseDialog(bool changed)
        {
            this.dialog.DialogResult = changed;
            this.dialog.KeyDown -= OnParentDlgKeyDown;
            this.dialog.Close();
        }

        private void Save()
        {
            this.employee.Name = this.Name;
            this.employee.Department = this.Department;
            this.employee.Salary = this.Salary;
            this.employee.Card.CardNumber = this.CardNumber;

            this.CloseDialog(true);
        }

        private void OnSave(object obj)
        {
            this.Save();
        }

        private bool CanSave(object obj)
        {
            return !String.IsNullOrEmpty(this.Name);
        }

        private void OnCancel(object obj)
        {
            this.CloseDialog(false);
        }
    }
}
