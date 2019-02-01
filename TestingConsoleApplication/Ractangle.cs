using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingConsoleApplication
{
    public delegate void RectDelegate(double wedth, double height);
    public delegate double RectDelegate1(double wedth, double height);
    class Ractangle
    {
        public void GetArea(double width,double height)
        {
            Console.WriteLine("Area of rectangle : "+width * height);
        }
        public void GetPerimeter(double width,double height)
        {
            Console.WriteLine("Perimeter of rectangle : " + 2 * (width + height));
        }

        public double GetArea1(double width, double height)
        {
            return + width * height;
        }
        public double GetPerimeter1(double width, double height)
        {
          return  2 * (width + height);
        }
        static void Main(string[] args)
        {
            Ractangle rect = new Ractangle();
            RectDelegate obj = rect.GetArea;
            obj += rect.GetPerimeter;
            obj.Invoke(12.34, 56.78);

            RectDelegate1 ob = rect.GetArea1;
            ob += rect.GetPerimeter1;

            Console.WriteLine(ob.Invoke(12.34, 56.78));

            //rect.GetArea(12.34, 56.78);
            //rect.getPerimeter(12.34, 56.78);

            Console.ReadKey();
        }
    }
}
