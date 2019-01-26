using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiaryMVVMApp1.Models
{
    /// <summary>
    /// 随记类，随时记录
    /// </summary>
    public class Remind : Item
    {
        public Remind()
        {
            date = DateTime.Now.ToLongTimeString();
        }
    }
}
