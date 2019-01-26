using DiaryMVVMApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiaryMVVMApp1.ViewModels
{
    public class DiaryContentViewModel : ContentViewModel
    {
        public Diary Diary { get; set; }

        public DiaryContentViewModel()
        {
            Diary = new Diary();
            Item = Diary;
        }

        protected override void NewItem(Item item)
        {
            base.NewItem(item);
            if(item is Diary)
            {
                Diary = item as Diary;
            }

        }
    }
}
