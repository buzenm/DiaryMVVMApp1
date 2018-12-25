﻿using DiaryMVVMApp1.Models;
using DiaryMVVMApp1.ViewModels.Commands;
using DiaryMVVMApp1.ViewModels.Commands.Bases;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DiaryMVVMApp1.ViewModels
{
    public class DiaryListViewModel
    {
        private ObservableCollection<Diary> diaries;

        private ObservableCollection<Group<string, Diary>> groups;
        public ObservableCollection<Group<string,Diary>> Groups
        {
            get
            {
                return groups;
            }
            
        }

        public DiaryListViewModel(ObservableCollection<Diary> _diaries)
        {
            diaries = _diaries;
            addCommand = new CommandBase(new Action(() => { }),
                new Func<bool>(() => { return true; }));
            groups = new ObservableCollection<Group<string, Diary>>();
            Grouping();
        }

        private void Grouping()
        {
            var items = from p in diaries
                        group p by p.Date.Substring(0, 8) into g
                        orderby g.Key
                        select g;
            foreach (var item in items)
            {
                groups.Add(new Group<string, Diary>
                {
                    GroupTitle = item.Key,
                    GroupItems = new ObservableCollection<Diary>(item.ToList())
                });
            }
        }

        public void Add()
        {

        }

        private CommandBase addCommand;
        public ICommand AddCommand
        {
            get
            {
                return addCommand;
            }
        }
    }
}
