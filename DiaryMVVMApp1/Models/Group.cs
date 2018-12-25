using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiaryMVVMApp1.Models
{
    public class Group<T,I>
    {
        public T GroupTitle { get; set; }

        public ObservableCollection<I> GroupItems { get; set; }

    }
}
