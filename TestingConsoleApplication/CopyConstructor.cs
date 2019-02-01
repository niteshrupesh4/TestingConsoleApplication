using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingConsoleApplication
{
    class CopyConstructor
    {
        int x;
        public CopyConstructor(int i)
        {
            x = i;
        }
        public CopyConstructor()
        {
            x = 50;
            Console.WriteLine("CopyConstructor without parametter : " + x);
        }
        static CopyConstructor()
        {
            Console.WriteLine("Static Constructor");
        }

        public void Display()
        {
            Console.WriteLine("Value of X : " +x);
        }
        public CopyConstructor(CopyConstructor ob)
        {
            x = ob.x;
        }
        public CopyConstructor(CopyConstructor obj,CopyConstructor obj1,CopyConstructor obj2)
        {
            Console.WriteLine("CopyConstructor without parametter obj : " + obj.x);
            Console.WriteLine("CopyConstructor without parametter obj1 : " + obj1.x);
            Console.WriteLine("CopyConstructor without parametter obj2 : " + obj2.x);
        }

        static void Main(string[] args)
        {
            CopyConstructor obj1 = new CopyConstructor(10);
            CopyConstructor obj = new CopyConstructor();
            //obj1.Display();
            CopyConstructor ob = new CopyConstructor(obj, obj1, obj);
            CopyConstructor obj2 = new CopyConstructor(obj1);
            obj2.Display();
            Console.ReadKey();
        }
    }
}
