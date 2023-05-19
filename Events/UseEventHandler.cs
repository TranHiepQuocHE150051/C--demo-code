using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    // Build class MyEventArgs that inherits from EventArgs 
    public class MyEventArgs : EventArgs
    {
        public MyEventArgs(string data)
        {
            this.data = data;
        }
        // Save data sent from publisher 
        private string data;

        public string Data
        {
            get { return data; }
        }
    }

    // Build class, broadcast event (data) 
    public class ClassA
    {
        // Create Event with EventHandler 
        public event EventHandler<MyEventArgs> event_news;

        public void Send()
        {
            event_news?.Invoke(this, new MyEventArgs("EC breaking news..."));
        }
    }

    public class ClassB
    {
        public void Sub(ClassA p)
        {
            p.event_news += ReceiverFromPublisher;
        }

        private void ReceiverFromPublisher(object sender, MyEventArgs e)
        {
            Console.WriteLine("ClassB: " + e.Data);
        }
    }

    public class ClassC
    {
        public void Sub(ClassA p)
        {
            p.event_news += ReceiverFromPublisher;
        }

        private void ReceiverFromPublisher(object sender, MyEventArgs e)
        {
            Console.WriteLine("ClassC: " + e.Data);
        }
    }

}
