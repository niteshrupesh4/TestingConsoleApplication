using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingConsoleApplication
{
    //Step 1 
    public delegate void AddDelegate(int a, int b);
    public delegate string SayDelegate(string name);
    public class Delegate
    {
        public void Addnums(int a,int b)
        {
            Console.WriteLine(a+b);
        }
        public static string SayHello(string name)
        {
            return "Hello " + name;
        }
        static void Main(string[] args)
        {
            Delegate p = new Delegate();
            //steep 2
            AddDelegate ad = new AddDelegate(p.Addnums);
            ad(120, 60);
            ad.Invoke(120, 60);

            SayDelegate sd = new SayDelegate(SayHello);        
            string str = sd("Nitesh kus.mIYY.pIUHhyiaha");
            str = str.ToProper();
            string str1 = sd.Invoke("Nitesh Kushwaha");
            Console.WriteLine(str);
            Console.ReadKey();
        }
    }
}
