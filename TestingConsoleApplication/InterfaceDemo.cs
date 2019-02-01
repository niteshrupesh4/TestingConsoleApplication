using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingConsoleApplication
{
    class InterfaceDemo : abZ, abc
    {
        public InterfaceDemo(int a) : base(a)
        {

        }

        static void Main(string[] args)
        {
            //Console.WriteLine("Hello Interface");
            //abZ.show();
            //abZ ob = new InterfaceDemo(16);

            int[] ar = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24 };

            List<string> list = new List<string>()
            {
                "Nitesh",  "Nitesh",  "pawan",  "Nitesh",  "rupesh",  "Nitesh",  "kunal",  "Nitesh",  "kisor",  "Nitesh",  "rahul",
            };
            // one way to split array to list by use of extaintion method
            var result = list.Split(6);

            foreach (var item in result)
            {
                foreach (var rst in item)
                {
                    Console.Write(rst+", ");
                }
                Console.WriteLine();
            }


            //var ii = ar.Split(5);

            #region  split with loop 
            // 2nd way to split array to list 
            /*var splitList = new List<List<int>>();
            var chunkCount = (int)Math.Ceiling((double)ar.Length / 5);
            for (int c = 0; c < chunkCount; c++)
            {
                var skip = c * 5;
                var take = skip + 5;
                var chunk = new List<int>(5);

                for (int e = skip; e < take && e < ar.Length; e++)
                {
                    chunk.Add(ar.ElementAt(e));
                }
                splitList.Add(chunk);
            }
           

            foreach (var item in splitList)
            {               
                foreach (var i in item)
                {
                    Console.Write(i + ",");
                }
                Console.WriteLine();
            } 
         */
            #endregion

            Console.ReadKey();
        }

        public override void sum()
        {
            Console.WriteLine("Sum");
        }

        public void xyz()
        {
            System.Console.WriteLine("In xyz");
        }
    }
    interface abc
    {
        void xyz();
    }

    public abstract class abZ
    {
        int a;
        public abZ()
        {
            a = 10;
        }
        public abZ(int a)
        {
            this.a = a;
            Console.WriteLine(this.a);
        }
        public abstract void sum();

        public static void show()
        {
            //Console.WriteLine(a);
        }
    }
}
