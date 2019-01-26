using DiaryMVVMApp1.Models;
using Prism.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiaryMVVMApp1.ViewModels.EventAggregators
{
    /// <summary>
    /// 内容页发送要保存的子项给列表页面模型
    /// </summary>
    public class GetInputMessages:PubSubEvent<Item>{}

    /// <summary>
    /// 列表页面模型发送初始化命令给内容子项
    /// </summary>
    public class GetInputMessages2 : PubSubEvent { }

    public class GetInputMessages3 : PubSubEvent<Remind> { }

    public class GetInputMessages4 : PubSubEvent<Diary> { }
}
