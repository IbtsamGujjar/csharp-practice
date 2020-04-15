using System;
using System.Threading.Tasks;

namespace DotNetPrac
{
    public delegate void Function(string message);
    class Program
    {
        public static void callback(string message)
        {
            Console.WriteLine("Callback: {0}", message);
        }
        
        static void Main(string[] args)
        {
            // Events & Delegates
            
            Publisher publisher = new Publisher();
            Subscriber subscriber = new Subscriber();
            publisher.EventPublished += subscriber.OnEventPublished;
            // Delegate instance
            Function handler = callback;

            publisher.ConnectToDb();
            publisher.GetData(callback);
            
            // Singleton Pattern
            
            // Invoking in parallel for thread safety
            Parallel.Invoke(
                () => LogEmployeeMessage(),
                () => LogManagerMessage()
                );
            Console.WriteLine("Number of instances created for Singleton: {0}",Singleton.counter);
        }
        private static void LogEmployeeMessage()
        {
            Singleton s1 = Singleton.GetInstance;
            s1.Logger("employee message");
        }
        private static void LogManagerMessage()
        {
            Singleton s2 = Singleton.GetInstance;
            s2.Logger("manager message");
        }
    }
}
