using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingConsoleApplication
{ 
    class LemdaExpration
    {
        public static string Greetings(string name)
        {
            return "Hello " + name + " a very good morning.";
        }
        static void Main(string[] args)
        {
            GreetingsDelegate obj = new GreetingsDelegate(Greetings);
            GreetingsDelegate obj5 = (name) =>
            {
                return "Hello " + name + " a very good morning.";
            };

            Func<int,float,double,double> obj1 = Generic1Delegates.AddNums1;
            double res = obj1.Invoke(100, 34.5f, 193.465);
            Console.WriteLine(res);

            Action<int,float,double> obj2 = Generic1Delegates.AddNums2;
            obj2.Invoke(100, 34.5f, 193.465);

            Predicate<string> obj3 = Generic1Delegates.checkLength;
            bool rr = obj3.Invoke("nitesh");
            Console.WriteLine(rr);

            //string str = obj.Invoke("Nitesh");
            //string str1 = obj5.Invoke("Nitesh");
            //Console.WriteLine(str);
            //Console.WriteLine(str1);
            Console.ReadKey();
        }
    }
}
