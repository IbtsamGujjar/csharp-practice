using System;
using System.Threading;

namespace DotNetPrac
{
    class Publisher
    {
        // creating a delegate for the event
        public delegate void EventPublishedEventHandler(object src, EventArgs e);

        // Can also use built-in event handler(Delegate)
        //public event EventHandler EventPublished;

        // event based on the delegate
        public event EventPublishedEventHandler EventPublished;

        public void ConnectToDb()
        {
            Console.WriteLine("Publisher: Connecting ....!");
            Thread.Sleep(2000);
            OnEventPublished();
        }
        protected virtual void OnEventPublished()
        {
            // If event has subscribers
            EventPublished?.Invoke(this, EventArgs.Empty);
        }

        public void GetData(Function callback)
        {
            Console.WriteLine("Getting Data...");
            Thread.Sleep(1000);
            callback("from callback");
        }
    }
}
