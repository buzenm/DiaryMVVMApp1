using DiaryMVVMApp1.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiaryMVVMApp1.ViewModels
{
    public class PivotViewModel
    {
        public string PivotTitle { get; set; }

        public IEnumerable<ObservableCollection<Item>> PivotItemLists { get; set; }

        public PivotViewModel()
        {
            
        }
    }
}
