using System;

namespace DotNetPrac
{
    public sealed class Singleton
    {
        public static int counter = 0;
        private static readonly object locked = new object();
        public static Singleton instance = null;
        // Property GetInstance with get accessor only
        public static Singleton GetInstance
        {
            get
            {
                if (instance == null)
                {
                    lock (locked)
                    {
                        if (instance == null)
                        {
                            instance = new Singleton();
                        }
                    }
                }
                return instance;
            }
        }
        private Singleton()
        {
            counter++;
        }
        public void Logger(string message)
        {
            Console.WriteLine("Logged: {0}", message);
        }
    }
}
