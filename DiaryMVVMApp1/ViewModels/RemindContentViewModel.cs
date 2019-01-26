using DiaryMVVMApp1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiaryMVVMApp1.ViewModels
{
    public class RemindContentViewModel:ContentViewModel
    {
        public Remind Remind { get; set; }

        public RemindContentViewModel()
        {
            Remind = new Remind();
            Item = Remind;
            
        }

        

        protected override void NewItem(Item item)
        {
            base.NewItem(item);
            if (item is Remind)
            {
                Remind = item as Remind;
            }

        }
    }
}
