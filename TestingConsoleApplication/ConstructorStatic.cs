using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingConsoleApplication
{
    class ConstructorStatic
    {
        static int y;
        int x;
        protected ConstructorStatic()
        {
            Console.WriteLine("protected constructor is called");
        }

        static ConstructorStatic()
        {
            Console.WriteLine("Satatic constructor is called");
        }
        //public ConstructorStatic()
        //{
        //    Console.WriteLine("Non-Satatic constructor is called");
        //}

        public static void Main(string[] args)
        {
            int m;
            ConstructorStatic ob = new ConstructorStatic();
            ConstructorStatic obj1 = ob;
            Console.ReadKey();
        }
    }
}
