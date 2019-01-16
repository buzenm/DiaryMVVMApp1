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

        public ListViewModel(ObservableCollection<Item> _items)
        {
            items = _items;
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
