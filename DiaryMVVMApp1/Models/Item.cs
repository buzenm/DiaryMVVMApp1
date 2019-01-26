using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiaryMVVMApp1.Models
{
    /// <summary>
    /// 记录类父类，时间初始化、只读
    /// </summary>
    public abstract class Item:INotifyPropertyChanged
    {
        protected string date;
        public string Date
        {
            get
            {
                return date;
            }
        }


        private string content;

        
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public string Content
        {
            get
            {
                return content;
            }
            set
            {
                if (content != value)
                {
                    content = value;
                    OnPropertyChanged("Content");
                }
            }
        }
        
    }
}
