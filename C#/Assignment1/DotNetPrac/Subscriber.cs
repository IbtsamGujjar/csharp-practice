using System;

namespace DotNetPrac
{
    class Subscriber
    {
        public void OnEventPublished(object src, EventArgs e)
        {
            Console.WriteLine("Subscriber: Event published from .. {0}", src);
        }
    }
}
