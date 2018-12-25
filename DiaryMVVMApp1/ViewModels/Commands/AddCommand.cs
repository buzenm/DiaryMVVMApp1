using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DiaryMVVMApp1.ViewModels.Commands
{
    public class AddCommand : ICommand
    {
        private DiaryListViewModel diaryListViewModel;

        public AddCommand(DiaryListViewModel _diaryListViewModel)
        {
            diaryListViewModel = _diaryListViewModel;
        }
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            diaryListViewModel.Add();
        }
        

    }
}
