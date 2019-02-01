using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsoleApplication
{
    public class A
    {
        public virtual void sum(int a, int b)
        {
            Console.WriteLine("Base " + (a + b));
        }
    }
    public class B :A
    {
        public override void sum(int a, int b)
        {
            Console.WriteLine("child " + (a + b));
            Console.WriteLine("child sum of sum " + (a + b)+(a + b));
        }
    }
    public class AA
    {
        public virtual void sum(int a, int b)
        {
            Console.WriteLine("Base " + (a + b));
        }
    }
    public class BB : AA
    {
        public new void sum(int a, int b)
        {
            Console.WriteLine("child " + (a + b));
            Console.WriteLine("child sum of sum " + (a + b) + (a + b));
        }
    }
    class OverrideClass
    {
        static void Main(string[] args)
        {
            A obj = new B();
            obj.sum(10,20);
            AA obj1 = new BB();
            obj1.sum(20, 20);
            Console.ReadKey();
        }
    }
}
