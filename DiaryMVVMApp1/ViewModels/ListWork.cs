using DiaryMVVMApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiaryMVVMApp1.ViewModels
{
    public abstract class ListWork
    {
        public virtual void AddAndUpdate(Item item) { }

        public virtual void Delete(Item item) { }
    }
}
