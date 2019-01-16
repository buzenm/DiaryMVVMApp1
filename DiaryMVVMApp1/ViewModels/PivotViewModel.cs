using DiaryMVVMApp1.Models;
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

        private ListWork listWork;

        private ListViewModel diaryListViewModel;
        private ListViewModel remindListViewModel;
        public PivotViewModel()
        {
            remindListViewModel = new ListViewModel(reminds);
            diaryListViewModel = new ListViewModel(diaries);
            listWork = remindListViewModel;
            //JianjiDatabase.GetInstance().Conn
        }
    }
}
