using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingConsoleApplication
{
    class TestExtantionMethod
    {
        static void Main(string[] args)
        {
            Program1 p = new Program1();
            p.Test1();
            p.Test2();
            p.Test3();
            var i = 20;
            long result = i.Factorial();
            String str = "Nitesh kumar.kushwaha";
            int compareValue;
            System.DateTime theDay = new System.DateTime(System.DateTime.Today.Year, 5, 21);

            compareValue = theDay.CompareTo(DateTime.Today);
           
            str = str.ToProper();
            Console.WriteLine(str);
            Console.WriteLine("Factorial of {0} is : {1}",i,result);
            Console.ReadKey();
        }
    }
}
