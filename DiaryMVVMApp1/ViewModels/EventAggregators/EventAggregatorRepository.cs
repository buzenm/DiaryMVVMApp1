using Prism.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiaryMVVMApp1.ViewModels.EventAggregators
{
    /// <summary>
    /// 提供事件聚合实例
    /// </summary>
    public class EventAggregatorRepository
    {
        public EventAggregatorRepository()
        {
            eventAggregator = new EventAggregator();
        }

        public IEventAggregator eventAggregator;
        public static EventAggregatorRepository eventRepository = null;

        //单例，保持内存唯一实例
        public static EventAggregatorRepository GetInstance()
        {
            if (eventRepository == null)
            {
                eventRepository = new EventAggregatorRepository();
            }
            return eventRepository;
        }


    }
}
