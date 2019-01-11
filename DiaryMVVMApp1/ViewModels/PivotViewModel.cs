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
        public DiaryListViewModel DiaryListViewModel { get; set; }

        
        public PivotViewModel()
        {
            //JianjiDatabase.GetInstance().Conn
        }
    }
}
