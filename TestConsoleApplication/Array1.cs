using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsoleApplication
{
    class Array1
    {
        static void Main(string[] args)
        {
            int[] ar = { 7, 20, 6, 5, 9, 2, 3 };    
                    
            Array.Sort(ar);
            Array.Reverse(ar);
           
            foreach (var item in ar)
            {
                Console.Write(item+", ");
            }
            Console.WriteLine();
            for (int i = ar.Length-1; i >= 0; i--)
            {
                Console.Write(ar[i] + ", ");
            }
            int temp;
            for (int i = 0; i < ar.Length; i++)
            {
                for (int j = 0; j < ar.Length - 1; j++)
                {
                    if (ar[j] > ar[j+1])
                    {
                        temp = ar[j];
                        ar[j] = ar[j + 1];
                        ar[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine();
            int[] arr = new int[20];
            Array.Copy(ar, arr, ar.Length-2);
            foreach (var item in arr)
            {
                Console.Write(item + ", ");
            }
            Console.ReadKey();
        }
    }
}
