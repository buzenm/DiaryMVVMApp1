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

        /// <summary>
        /// 增加或更新
        /// </summary>
        void AddAndUpdate(Item item);

        /// <summary>
        /// 删除
        /// </summary>
        void Delete();
    }
}
