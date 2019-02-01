using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsoleApplication
{
    class Generics2<T>
    {
        public void Add(T a, T b)
        {
            dynamic c = a;
            dynamic d = b;
            Console.WriteLine(c + d);
        }
        public void Sub(T a, T b)
        {
            dynamic c = a;
            dynamic d = b;
            Console.WriteLine(c - d);
        }
        public void Mul(T a, T b)
        {
            dynamic c = a;
            dynamic d = b;
            Console.WriteLine(c * d);
        }
        public void Div(T a, T b)
        {
            dynamic c = a;
            dynamic d = b;
            Console.WriteLine(c / d);
        }
    }
    class TestGenerics
    {
        static void Main(string[] args)
        {
            List<int> li = new List<int>();
            Generics2<int> obj = new Generics2<int>();
            obj.Add(10, 20);
            obj.Sub(10, 20);
            obj.Mul(10, 20);
            obj.Div(10, 20);
            Dictionary<int, string> dict = new Dictionary<int, string>()
                                            {
                                                {1,"One"},
                                                {5,"Five"},
                                                {4, "Four"},
                                                {2, "Two"},
                                                {3,"Three"}
                                            };
            
            Console.ReadKey();
        }
    }
    
}
