using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DiaryMVVMApp1.ViewModels.Commands.Bases
{
    public class CommandBase : ICommand
    {
        private Action whatToExecute;
        private Func<bool> whenToExecute;

        public CommandBase(Action what,Func<bool> when)
        {
            whatToExecute = what;
            whenToExecute = when;
        }
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return whenToExecute();
        }

        public void Execute(object parameter)
        {
            whatToExecute();
        }
    }
}
