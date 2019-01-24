using DiaryMVVMApp1.Models;
using DiaryMVVMApp1.ViewModels.EventAggregators;
using DiaryMVVMApp1.ViewModels.Interfaces;
using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiaryMVVMApp1.ViewModels
{
    public class PivotViewModel
    {
        //public DiaryListViewModel DiaryListViewModel { get; set; }

        private ObservableCollection<Diary> diaries;
        public ObservableCollection<Diary> Diaries { get; set; }

        private ObservableCollection<Remind> reminds;
        public ObservableCollection<Remind> Reminds { get; set; }

        private IListWork listWork;

        private ListViewModel diaryListViewModel;
        private ListViewModel remindListViewModel;
        public PivotViewModel() 
        {
            reminds = new ObservableCollection<Remind>();
            diaries = new ObservableCollection<Diary>();
            remindListViewModel = new ListViewModel(reminds);
            diaryListViewModel = new ListViewModel(diaries);
            listWork = remindListViewModel;
            //JianjiDatabase.GetInstance().Conn
            AddAndUpdateCommand = new DelegateCommand(new Action(listWork.AddAndUpdate));
            deleteCommand = new DelegateCommand(new Action(listWork.Delete));

            SetSubscribe();
        }

        private void SetSubscribe()
        {
            EventAggregatorRepository
                .GetInstance()
                .eventAggregator
                .GetEvent<GetInputMessages>()
                .Subscribe(new Action<Item>(listWork.AddAndUpdate));
        }

        public void ChangeSelect()
        {
            if (listWork == remindListViewModel)
                listWork = diaryListViewModel;
            else
                listWork = remindListViewModel;
        }

        public DelegateCommand AddAndUpdateCommand { get; set; }

        private DelegateCommand deleteCommand;
        public DelegateCommand DeleteCommand
        {
            set
            {
                value = deleteCommand;
            }
            get
            {
                return deleteCommand;
            }
        }

    }
}
