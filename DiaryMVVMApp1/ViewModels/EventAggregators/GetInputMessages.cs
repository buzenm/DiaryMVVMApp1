using DiaryMVVMApp1.Models;
using Prism.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiaryMVVMApp1.ViewModels.EventAggregators
{
    public class GetInputMessages:PubSubEvent<Item>
    {
    }
}
