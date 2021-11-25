using System;
using System.Collections.Generic;
using System.Text;

namespace DelegatesEvents
{
    public delegate int  operation(int a, int b);
    class DelegateDemo
    {
      public static int Addition(int x,int y)
        {
            return x + y;

        }
       
    }
}
