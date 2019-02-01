using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingConsoleApplication
{
    public class Test1
    {
        protected class v1
        {
            public void m1()
            {
                Console.WriteLine("protected internal class m1 method");
            }
        }
        protected internal void test()
        {
            Console.WriteLine("Test method");
        }
    }
}
