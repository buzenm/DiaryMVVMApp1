using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiaryMVVMApp1.Models
{
    /// <summary>
    /// 分组
    /// </summary>
    /// <typeparam name="T">分组标题类型</typeparam>
    /// <typeparam name="I">分组内容类型</typeparam>
    public class Group<T,I>
    {
        public T GroupTitle { get; set; }

        public ObservableCollection<I> GroupItems { get; set; }

    }
}
