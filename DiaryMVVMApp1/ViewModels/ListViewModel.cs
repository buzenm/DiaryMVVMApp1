using DiaryMVVMApp1.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiaryMVVMApp1.ViewModels
{
    public class ListViewModel:ListWork
    {
        private ObservableCollection<Item> items;

        //public ListViewModel(ObservableCollection<Remind> reminds)
        //{
        //    foreach (var item in reminds)
        //    {
        //        items.Add(item);
        //    }
        //}

        //public ListViewModel(ObservableCollection<Diary> diaries)
        //{
        //    foreach (var item in diaries)
        //    {
        //        items.Add(item);
        //    }
        //}
        public ListViewModel(IEnumerable<Item> items)
        {
            
            foreach (var item in items)
            {
                this.items.Add(item);
            }
        }

        /// <summary>
        /// 增加新项或者更新已有项
        /// </summary>
        /// <param name="item"></param>
        public override void AddAndUpdate(Item item)
        {
            List<string> dates = new List<string>();
            foreach (var item1 in items)
            {
                dates.Add(item1.Date);
            }
            if (dates.Contains(item.Date))
                items[dates.IndexOf(item.Date)] = item;
            else
                items.Add(item);
        }
        /// <summary>
        /// 删除已有项
        /// </summary>
        /// <param name="item"></param>
        public override void Delete(Item item)
        {
            if(items.Contains(item))
                items.Remove(item);
        }
        

    }
}
