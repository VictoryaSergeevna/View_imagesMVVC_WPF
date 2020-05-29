﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVM_Images.Helpers
{
    public class RelayCommand : ICommand
    {
        public event EventHandler CanExecuteChanged
        {
            //следит за способностью выполнятся
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
        Action<object> execute;
        //delegate bool MyCan...(object param);
        //Mycan... canExecute;
        Func<object, bool> canExecute;
        public RelayCommand(Action<object> execute, Func<object, bool> canExecute = null)
        {
            this.execute = execute;
            this.canExecute = canExecute;

        }
        public bool CanExecute(object parameter)
        {
            return canExecute == null || this.canExecute(parameter);
        }

        public void Execute(object parameter)
        {
            this.execute(parameter);
        }
    }
}
