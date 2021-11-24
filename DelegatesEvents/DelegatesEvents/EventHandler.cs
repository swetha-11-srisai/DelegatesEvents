using System;
using System.Collections.Generic;
using System.Text;

namespace DelegatesEvents
{
    public delegate void DelEventHandler();
    class EventHandler
    {
        public static void India()
        {
            Console.WriteLine("India");
        }
        public static void USA()
        {
            Console.WriteLine("USA");
        }
    }
}
