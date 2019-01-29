using DiaryMVVMApp1.Models;
using DiaryMVVMApp1.ViewModels.EventAggregators;
using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiaryMVVMApp1.ViewModels
{
    /// <summary>
    /// 记录子项内容视图模型
    /// </summary>
    public class ContentViewModel
    {
        public Item Item { get; set; }

        /// <summary>
        /// 发送保存命令给列表视图模型
        /// </summary>
        public void Save()
        {
            
            EventAggregatorRepository
                .GetInstance()
                .eventAggregator
                .GetEvent<GetInputMessages>()
                .Publish(Item);
        }

        public DelegateCommand SaveCommand { get; set; }

        public ContentViewModel()
        {
            SetSubscribe();
            SaveCommand = new DelegateCommand(new Action(Save));
        }

        /// <summary>
        /// 接收一个item初始化内容
        /// </summary>
        /// <param name="item"></param>
        protected virtual void NewItem(Item item) { }

        /// <summary>
        /// 接收一个item用于改变内容
        /// </summary>
        private void SetSubscribe()
        {
            EventAggregatorRepository
                .GetInstance()
                .eventAggregator
                .GetEvent<GetInputMessages>()
                .Subscribe(new Action<Item>(NewItem));
        }
    }
}
