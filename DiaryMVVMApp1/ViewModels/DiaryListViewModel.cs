using DiaryMVVMApp1.Models;
using DiaryMVVMApp1.ViewModels.Commands;
using DiaryMVVMApp1.ViewModels.Commands.Bases;
using Prism.Commands;
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
        public ObservableCollection<Diary> Diaries
        {
            get;
        }

        private ObservableCollection<Group<string, Diary>> groups;
        public ObservableCollection<Group<string,Diary>> Groups
        {
            get;
            
        }

        public DiaryListViewModel(ObservableCollection<Diary> _diaries)
        {
            diaries = _diaries;
            addCommand = new DelegateCommand(new Action(AddandUpdate),
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
        private Diary addDiary;
        public Diary AddDiary
        {
            set
            {
                addDiary = value;
            }
        }
        private void AddandUpdate()
        {
            var exit = from p in diaries
                       where p.Date == addDiary.Date
                       select p;
            if (exit != null)
            {
                foreach (var item in exit)
                {
                    diaries[diaries.IndexOf(item)] = addDiary;
                    
                }
            }
            else
            {
                diaries.Add(addDiary);
            }
        }

        private void Delete(Diary _diary)
        {
            diaries?.Remove(_diary);
        }

        private CommandBase deleteCommand;
        public ICommand DeleteCommand
        {
            get
            {
                return deleteCommand;
            }
        }

        private DelegateCommand addCommand;
        public ICommand AddCommand
        {
            get
            {
                return addCommand;
            }
        }
    }
}
