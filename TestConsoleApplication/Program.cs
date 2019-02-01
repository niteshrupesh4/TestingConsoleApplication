using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingConsoleApplication;

namespace TestConsoleApplication
{
    class BaseGC

    {
        public void Display()
        {
            Console.WriteLine("Example Method");
        }
        public void Add(int i,Single j,float d)
        {
            Console.WriteLine(i+j+d);
        }
    }

    class Program : BaseGC
    {
        public static long Fact(int x)
        {
            if (x == 1)
                return 1;
            if (x == 2)
                return 2;
            else
                return x * Fact(x - 1);
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Add(55, 44.33f, 55.6f);

            string str = "";
            Console.Write("please enter text : ",str);
            str = Console.ReadLine();
            Console.WriteLine(str.Count(c => c == 'h'));           
            int length = str.Length-1;
            string sum = "";
            str.ToArray();
            while (length>=0)
            {
                sum = sum + str[length];
                length--;
            }
            Console.WriteLine(sum);
            int num = 0;
            Console.Write("Please Enter number : ");
             num=Convert.ToInt32(Console.ReadLine());

            int temp=0, total=0, total1 = 0, temp2=0, temp1 =0, total2 = 0;

            temp = num;
            temp1 = num;
            temp2 = num;
            //while (num > 0)
            //{
            //    int c = num % 10;
            //    total = total * 10 + c;
            //    num = num / 10;
            //}
            //Console.WriteLine("Enter value {0} , result {1}",num,total);

            ///reverse number
            while (temp > 0)
            {
                int c = temp % 10;
                total = total * 10 + c;
                temp = temp / 10;
            }
           
            Console.WriteLine("Enter value {0} ,reverse number result {1}", num, total);

            //armstrong number
            while (temp1 > 0)
            {
                int c = temp1 % 10;
                total1 = total1 + c * c * c;
                temp1 = temp1 / 10;
            }
            Console.WriteLine("Enter value {0} ,armstrong number result {1}", num, total1);
            //Total sum
            while (temp2 > 0)
            {
                int c = temp2 % 10;
                total2 = total2 + c;
                temp2 = temp2 / 10;
            }
            Console.WriteLine("Enter value {0} ,Total sum result {1}", num, total2);

            int a = 10, b = 50;
            Console.WriteLine("Before swape a = {0} , b = {1}", a, b);
            a = a * b;
            b = a / b;
            a = a / b;
            Console.WriteLine("After swape a = {0} , b = {1}", a, b);

            Console.WriteLine("Factorial with recurcive " + Fact(10));
            //Prime Nummber
            int number = 10;
            bool flag = true;
            Console.Write("Prime Nummber ");
            for (int i = 2; i <= number; i++)
            {
                for (int j = 2; j <= number/2; j++)
                {
                    if (i != j && i % j == 0)
                    {
                        flag = false;
                        break;
                    }
                }             
                if (flag)
                {                  
                    Console.Write(" " + i);
                }
                flag = true;
            }

            //fibonacci serise
            int fist = 0, secand = 1, sum1 = 0;
            Console.WriteLine( );
            Console.Write("fibonacci serise {0},{1}", fist,secand);

            for (int i = 0; i <= number; i++)
            {
                sum1 = fist + secand;
                Console.Write("," + sum1);
                fist = secand;
                secand = sum1;
               
            }

            Console.ReadKey();
        }
    }
}
