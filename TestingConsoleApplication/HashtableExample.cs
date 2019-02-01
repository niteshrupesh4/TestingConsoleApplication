using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingConsoleApplication
{
    class HashtableExample
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add(1, "One");
            ht.Add(2, "Two");
            ht.Add(3, "Three");
            ht.Add(4, "Four");
            ht.Add(5, null);
            ht.Add("Fv", "Five");
            ht.Add(8.5F, 8.5);
            for (int i = 0; i < ht.Count; i++)
            {
                Console.WriteLine("Value : "+ht[i] );
            }
            foreach (DictionaryEntry item in ht)
            {
                Console.WriteLine("key : " + item.Key + "  " + "Value : " + item.Value);
            }
            foreach (var item in ht.Values)
            {
                Console.WriteLine("value "+item);
            }
            Console.WriteLine(ht.Count);
            Console.ReadKey();
        }
    }
}
