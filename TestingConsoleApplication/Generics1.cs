using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingConsoleApplication
{
    class Generics1
    {
        public bool Compare<T>(T a, T b)
        {
            if (a.Equals(b))
                return true;
            return false;
        }
        static void Main(string[] args)
        {
            Generics1 obj = new Generics1();
            bool result = obj.Compare<string>("10", "10");
            Console.WriteLine(result);
            Console.ReadKey();

        }
    }
}
