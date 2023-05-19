using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    // 
    public class Publisher
    {
        // declare an event 
        public delegate void NotifyNews(object data);

        public NotifyNews event_news;

        public void Send()
        {
            event_news?.Invoke("Have a news");
        }
    }

    public class SubscriberA
    {
        public void Sub(Publisher p)
        {
            p.event_news += ReceiverFromPublisher;
        }

        void ReceiverFromPublisher(object data)
        {
            Console.WriteLine("SubscriberA: " + data.ToString());
        }
    }

    public class SubscriberB
    {
        public void Sub(Publisher p)
        {
            //p.event_news = null;  // Destroy other objects receiving events
            p.event_news += ReceiverFromPublisher;
        }

        void ReceiverFromPublisher(object data)
        {
            Console.WriteLine("SubscriberB: " + data.ToString());
        }
    }

}
