using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingConsoleApplication
{
    static class StateClass
    {
        public static void Test3(this Program1 p)
        {
            Console.WriteLine("Test 3 EXT method call");
        }
        public static void Test2(this Program1 p)
        {
            Console.WriteLine("Test 2 EXT method call");
        }
        public static IEnumerable<IEnumerable<T>> Split<T>(this ICollection<T> self, int chunkSize)
        {
            var splitList = new List<List<T>>();
            var chunkCount = (int)Math.Ceiling((double)self.Count / (double)chunkSize);

            for (int c = 0; c < chunkCount; c++)
            {
                var skip = c * chunkSize;
                var take = skip + chunkSize;
                var chunk = new List<T>(chunkSize);

                for (int e = skip; e < take && e < self.Count; e++)
                {
                    chunk.Add(self.ElementAt(e));
                }

                splitList.Add(chunk);
            }

            return splitList;
        }

        public static long Factorial(this Int32 x)
        {
            if (x == 1)
                return 1;
            if (x == 2)
                return 2;
            else
                return x * Factorial(x - 1);
        }
        public static string ToProper(this String oldStr)
        {
            if (oldStr.Trim().Length > 0)
            {
                String NewStr = null;
                oldStr = oldStr.ToLower();
                string[] sarr = oldStr.Split('.');
                string[] sarr1 = oldStr.Split(' ');
                foreach (string item in sarr)
                {
                    char[] charr = item.ToCharArray();
                    charr[0] = Char.ToUpper(charr[0]);
                    if (NewStr == null)
                        NewStr = new string(charr);
                    else
                        NewStr += " "+ new string(charr);

                }
                return NewStr;
            }
            return oldStr;           

        }
    }
}
