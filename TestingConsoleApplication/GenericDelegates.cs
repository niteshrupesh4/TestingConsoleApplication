using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingConsoleApplication
{
    //public delegate double Delegaet1(int x, float y, double z);
    //public delegate void Delegaet2(int x, float y, double z);
    //public delegate bool Delegaet3(string str);
    public class Generic1Delegates
    {
        public static double AddNums1(int x,float y,double z)
        {
            return x + y + z;
        }
        public static void AddNums2(int x, float y, double z)
        {
            Console.WriteLine(x + y + z);
        }
        public static bool checkLength(string str)
        {
            if (str.Length > 5)
                return true;
            else
                return false;
        }
        static void Main(string[] args)
        {
            Func<int,float,double,double> obj1 = AddNums1;
            double res = obj1.Invoke(100, 34.5f, 193.465);
            Console.WriteLine(res);

            Action<int,float,double> obj2 = AddNums2;
            obj2.Invoke(100, 34.5f, 193.465);

            Predicate<string> obj3 = checkLength;
            bool rr = obj3.Invoke("nitesh");
            Console.WriteLine(rr);

            Console.ReadKey();
        }
    }
}
