using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingConsoleApplication
{
    public delegate string GreetingsDelegate(string name);
    class AnonymousMethod
    {
        static void Main(string[] args)
        {
            //GreetingsDelegate obj = new GreetingsDelegate(Greetings);
            GreetingsDelegate obj = delegate (string name)
            {
                return "Hello " + name + " a very good morning.";
            };
            Func<string, string, string> obj1 = delegate (string n, string n1)
             {
                 return "Hello " + n + " " + n1;
             };

            Action<int, int> oo = delegate (int a, int b)
             {
                 Console.WriteLine(a+b);
             };
            oo(100,99);
            string str = obj.Invoke("Nitesh");
            Console.WriteLine(obj1.Invoke("Nitesh", "Kushwaha"));
            Console.WriteLine(str);
            Console.ReadKey();
        }
    }
}
