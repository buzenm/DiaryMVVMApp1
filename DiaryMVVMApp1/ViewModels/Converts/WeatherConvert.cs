using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace DiaryMVVMApp1.ViewModels.Converts
{
    /// <summary>
    /// 天气转换器 string int
    /// </summary>
    public class WeatherConvert:IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            string s = value?.ToString();
            switch (s)
            {
                case "晴":
                    return 0;
                case "多云":
                    return 1;
                case "阴":
                    return 2;
                case "雨":
                    return 3;
                default:
                    return -1;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            int i = (int)value;
            switch (i)
            {
                case 0:
                    return "晴";
                case 1:
                    return "多云";
                    case 2:
                    return "阴";
                case 3:
                    return "雨";
                default:
                    return null;
            }
        }
    }
}
