using DiaryMVVMApp1.Models;
using DiaryMVVMApp1.Models.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiaryMVVMApp1.ViewModels
{
    public class DiaryContentViewModel:NotifyPropertyChangedBase
    {
        private Diary diary;

        public Diary Diary
        {
            get
            {
                return diary;
            }
            set
            {
                if (diary != value)
                {
                    diary = value;
                    OnPropertyChanged("Diary");
                }
            }
        }

        public DiaryContentViewModel(Diary _diary)
        {
            diary = _diary;
        }

        private void Reset()
        {
            diary.Date = DateTime.Now.ToString();
            diary.Weather = "";
            diary.Content = "";
        }
    }
}
