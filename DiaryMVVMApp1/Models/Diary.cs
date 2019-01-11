using DiaryMVVMApp1.Models.Bases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiaryMVVMApp1.Models
{
    public class Diary:Item
    {
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
        public Diary item
        {
            get
            {
                return this;
            }
        }
        
    }
}
