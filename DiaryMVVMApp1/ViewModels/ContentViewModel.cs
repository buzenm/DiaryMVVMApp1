﻿using DiaryMVVMApp1.Models;
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
            SetSubscribe();
            SaveCommand = new DelegateCommand(new Action(Save));
        }

        protected virtual void NewItem(Item item) { }

        private void SetSubscribe()
        {
            EventAggregatorRepository
                .GetInstance()
                .eventAggregator
                .GetEvent<GetInputMessages>()
                .Subscribe(new Action<Item>(NewItem));
        }
    }
}
