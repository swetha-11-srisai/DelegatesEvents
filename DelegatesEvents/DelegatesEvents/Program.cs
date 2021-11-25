using System;

namespace DelegatesEvents
{
    class Program
    {
        public static event DelEventHandler add;
        static void Main(string[] args)
        {
            operation obj = new operation(DelegateDemo.Addition);
            Console.WriteLine("Addition:{0}", obj(11, 27));
            MulticastDelegate.ImplementDelegate();

            add += new DelEventHandler(EventHandler.India);
            add += new DelEventHandler(EventHandler.USA);
            add.Invoke();
           

        }

    }
}
