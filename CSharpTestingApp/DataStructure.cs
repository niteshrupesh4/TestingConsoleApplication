using System;
using System.Linq;

namespace CSharpTestingApp
{
    class DataStructure
    {
        public void ArrayRev()
        {
            int[] a = { 1, 3, 4, 5, 67, 8 };
            int i = 0, j = a.Length - 1;
            for (int k = 0; k < a.Length; k++)
            {
                Console.Write(a[k] + ",");
            }
            Console.WriteLine();
            while (i < j)
            {
                int temp = a[i];
                a[i] = a[j];
                a[j] = temp;
                i++;
                j--;
            }
            for (int k = 0; k < a.Length; k++)
            {
                Console.Write(a[k] + ",");
            }

            Console.WriteLine();

            do
            {
                int temp = a[i];
                a[i] = a[j];
                a[j] = temp;
                i++;
                j--;
            } while (i < j);

            for (int k = 0; k < a.Length; k++)
            {
                Console.Write(a[k] + ",");
            }
        }

        public int factorial(int i)
        {
            if (i == 0)
            {
                return 1;
            }
            else
            {
                return i * factorial(i - 1);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public string NameReverse(string str)
        {
            int i = str.Count() - 1;
            if (i == 0)
            {
                return str;
            }
            else
            {
                string s = "";
                return str + " " + NameReverse(str.Substring(0, str.Length - 1));
            }
        }
        static void Main(string[] args)
        {
            DataStructure ds = new DataStructure();
            Console.WriteLine(ds.factorial(9));
            string inputString = "CodeProject";
            string lastCharacter = inputString.Substring(0, inputString.Length - 1); 
            Console.WriteLine(ds.NameReverse("Nitesh"));
            Console.ReadLine();
        }
    }
}
