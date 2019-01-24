using DiaryMVVMApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiaryMVVMApp1.ViewModels.Interfaces
{
    interface IListWork
    {
        void AddAndUpdate();

        void AddAndUpdate(Item item);
        void Delete();
    }
}
