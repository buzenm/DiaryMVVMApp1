using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiaryMVVMApp1.Models
{
    /// <summary>
    /// 日记类，每日一记
    /// </summary>
    public class Diary:Item
    {
        public Diary()
        {
            date = DateTime.Now.ToLongDateString();
        }
        private string weather;
        public string Weather
        {
            get
            {
                return weather;
            }
            set
            {
                if (weather != value)
                {
                    weather = value;
                    OnPropertyChanged("Weather");
                }
            }
        }
        
    }
}
