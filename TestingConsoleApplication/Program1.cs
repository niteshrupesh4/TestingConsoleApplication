using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingConsoleApplication
{
    class Program1
    {
        public void Test1()
        {
            Console.WriteLine("Test 1 Method call");
        }
        public void Test2()
        {
            Console.WriteLine("Test 2 Method call");
        }

        static void Main(string[] args)
        {
            Program1 obj = new Program1();
            obj.Test1();
            obj.Test2();
            Console.ReadKey();
        }
    }
}
