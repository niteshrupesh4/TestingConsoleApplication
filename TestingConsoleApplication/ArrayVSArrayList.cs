using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingConsoleApplication
{
    class ArrayVSArrayList
    {
        static void Main(string[] args)
        {
            int[] Array = new int[1000];
            int[] Array1 = new int[2] { 5, 9 };
            string[] Array2 = new string[2];
            for (int i = 0; i < Array1.Length; i++)
            {
                Array2[i] = Convert.ToString(Array1[i]);
                Console.WriteLine(Array2[i]);
            }
            List<int> li = new List<int>() { 1, 5, 9, 10 };
            List<string> lis = new List<string>();
            int lenght = li.Count;
            for (int k = 0; k < lenght; k++)
            {
                lis.Add(Convert.ToString(li[k]));


            }
            foreach (var item in lis)
            {
                Console.WriteLine(item);
            }
            ArrayList objArraylist = new ArrayList();
            Stopwatch objWatch1 = new Stopwatch();
            Stopwatch objWatch = new Stopwatch();
            objWatch.Start();
            Console.WriteLine("Array time taken start : " + objWatch.ElapsedTicks.ToString());
            for (int i = 0; i < 1000; i++)
            {
                Array[i] = DateTime.Now.Millisecond;
            }
            foreach (int i in Array)
            {
                Console.WriteLine(i+", ");
            }
            Console.WriteLine("Array count "+Array.Length);
            objWatch.Stop();
            Console.WriteLine("Array time taken End : " + objWatch.ElapsedTicks.ToString());
            objWatch1.Start();
            Console.WriteLine("Arraylist time taken Start : " + objWatch1.ElapsedTicks.ToString());
            for (int j = 0; j < 1000; j++)
            {
                objArraylist.Add(DateTime.Now.Second.ToString());
            }
            foreach (object i in objArraylist) { }
            objWatch1.Stop();
            Console.WriteLine("Arraylist time taken End : " + objWatch1.ElapsedTicks.ToString());
            Console.ReadLine();
        }
    }
}
