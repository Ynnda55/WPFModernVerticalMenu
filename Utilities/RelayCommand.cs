using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPFModernVerticalMenu.Utilities
{
    class RelayCommand : ICommand
    {
        private readonly Action<object> _execute;
        private readonly Func<object, bool> _canExecute;

        // Sobrecarga para lambdas con parámetros (obligatorios)
        public RelayCommand(Action<object> execute, Func<object, bool> canExecute = null)
        {
            _execute = execute;
            _canExecute = canExecute;
        }

        // Sobrecarga para lambdas sin parámetros (opcionales)
        public RelayCommand(Action execute, Func<bool> canExecute = null)
        {
            _execute = execute != null ? new Action<object>(_ => execute()) : null;
            _canExecute = canExecute != null ? new Func<object, bool>(_ => canExecute()) : null;
        }


        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            return _canExecute == null || _canExecute(parameter);
        }

        public void Execute(object parameter)
        {
            _execute(parameter);
        }

        // Codigo generado por Visual Studio

        //public event EventHandler CanExecuteChanged;
        //public void RaiseCanExecuteChanged()
        //{
        //    CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        //}
    }
}
