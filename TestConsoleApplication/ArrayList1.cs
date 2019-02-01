using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsoleApplication
{
    class ArrayList1
    {
        static void Main(string[] args)
        {
            //ArrayList arryList2 = new ArrayList();
            //arryList2.Add(100);
            //arryList2.Add(200);
            ArrayList arryList1 = new ArrayList();
            Console.WriteLine(arryList1.Add(100)); 
            arryList1.Add(200);
            Console.WriteLine(arryList1.Capacity);
            Console.WriteLine(arryList1.IsFixedSize);
            Console.WriteLine(arryList1.IsReadOnly);
            ArrayList arryList2 = new ArrayList();
            arryList2.Add(10);
            arryList2.Add(20);
            arryList2.Add(30);

            arryList2.InsertRange(2, arryList1);

            foreach (var item in arryList2)
                Console.WriteLine(item);

            Console.ReadKey();
        }
    }
}
