using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingConsoleApplication
{
    class ExeptionExample
    {
        static void Main(string[] args)
        {
            string s = null;
            try
            {
                int i = 10 ;
                Console.WriteLine(Convert.ToString(s));
                int j = 0;
                //int k = i / j;
                //Console.WriteLine(k);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("DivideByZeroException :: " + ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception ::" + ex);
            }
            Console.ReadKey();
        }
    }
}
