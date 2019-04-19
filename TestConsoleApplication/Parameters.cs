using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsoleApplication
{
    public class Parameters
    {
        static void ValueParameter(int i)
        {
            Console.WriteLine("Value parameter : "+ i);
        }
        static void RefParameter(ref int y)
        {
            y = 100;
            Console.WriteLine("Ref parameter : " + y);
        }
        static void OutParameter(out int y)
        {
            y = 10;
            Console.WriteLine("Out parameter : " + y);
        }
        static void ArrayParameter(params int[] p)
        {
            int s = 0;
            foreach (var item in p)
            {
                s += item;
                Console.WriteLine("Array parameter : " + item);
            }
            Console.WriteLine(s);
        }
        static void Main(string[] args)
        {
            int x = 20;
            int y = 55;
            ValueParameter(50);
            RefParameter(ref x);
            OutParameter(out y);
            ArrayParameter(1, 9, 8, 7);
            Console.ReadLine();
        }
    }
}
