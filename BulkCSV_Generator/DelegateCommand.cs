using System;
using System.Windows.Input;

namespace BulkCSV_Generator
{
    public class DelegateCommand
        : ICommand
    {
        public event EventHandler CanExecuteChanged;
        public Action<object> ExecuteHandler;
        public Func<object, bool> CanExecuteHandler;

        public bool CanExecute(object? parameter)
        {
            return (this.CanExecuteHandler == null) ? true : this.CanExecuteHandler(parameter);
        }

        public void Execute(object? parameter)
        {
            this.ExecuteHandler?.Invoke(parameter);
        }

        public void RaiseCanExecuteChanged()
        {
            this.CanExecuteChanged(this, null);
        }
    }
}