using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingConsoleApplication
{
    class Test2:Test1
    {
        static void Main(string[] args)
        {
            Test1 p = new Test1();
            Test1.v1 t= new Test1.v1();
            t.m1();
            p.test();
            Console.ReadKey();
        }
    }
}
