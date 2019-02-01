using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsoleApplication
{
    class Genral:ClassA
    {
        public Genral(int a) : base(a)
        {
        }

        static void Main(string[] args)
        {
            Genral o = new Genral(200);
            Console.WriteLine("abstract class");
            Console.WriteLine(o.sum(50,55));
            Console.WriteLine(o.MemberwiseClone());
            Console.ReadKey();
        }

        public override int sum(int a, int b)
        {
            return a + b;
        }
    }

    abstract class ClassA
    {
        public ClassA(int a)
        {
            Console.WriteLine("ClassA " + a);
        }
        public abstract int sum(int a, int b);
    }

    public interface Itest1
    {
         void Add(int a, int b);
    }

    public interface ITest2:Itest1
    {
         void Sub(int a, int b);

    }
}
