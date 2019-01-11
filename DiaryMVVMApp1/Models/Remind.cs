using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiaryMVVMApp1.Models
{
    public class Remind : Item
    {
        public override Item GetItem()
        {
            return this;
        }
    }
}
