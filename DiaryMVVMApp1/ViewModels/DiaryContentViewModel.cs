using DiaryMVVMApp1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiaryMVVMApp1.ViewModels
{
    public class DiaryContentViewModel
    {
        private Diary diary;

        

        public DiaryContentViewModel(Diary _diary)
        {
            diary = _diary;
        }

        private void Reset()
        {
            diary = new Diary(DateTime.Now.ToLongDateString());
        }
    }
}
