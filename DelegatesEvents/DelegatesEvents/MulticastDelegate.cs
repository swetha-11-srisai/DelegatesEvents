using System;
using System.Collections.Generic;
using System.Text;

namespace DelegatesEvents
{
    delegate void Delop(int a, int b);
    class MulticastDelegate
    {
       
        public static void ImplementDelegate()
        {
            Delop objone = Operation.Add;
            objone += Operation.Sub;

            objone(3, 3);
            objone(6, 2);

        }

        public class Operation
        {
            public static void Add(int x , int y)
            {
                Console.WriteLine("Addition:{0}",x+y);
            }
            public static void Sub(int x, int y)
            {
                Console.WriteLine("subraction:{0}", x - y);
            }
        }
    }
}
