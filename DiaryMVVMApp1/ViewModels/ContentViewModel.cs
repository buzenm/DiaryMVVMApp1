using DiaryMVVMApp1.Models;
using DiaryMVVMApp1.ViewModels.EventAggregators;
using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiaryMVVMApp1.ViewModels
{
    public class ContentViewModel
    {
        public Item Item { get; set; }

        public Diary Diary { get; set; }

        public Remind Remind { get; set; }

        public void Save()
        {
            
            EventAggregatorRepository
                .GetInstance()
                .eventAggregator
                .GetEvent<GetInputMessages>()
                .Publish(Item);
        }

        public DelegateCommand SaveCommand { get; set; }

        public ContentViewModel()
        {
            Remind = new Remind();
            Item = Remind;
            SaveCommand = new DelegateCommand(new Action(Save));
        }
    }
}
