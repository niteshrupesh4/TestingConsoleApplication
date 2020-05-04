using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTestingApp
{
    class ParseTryParse
    {
        static void Main(string[] args)
        {
            string str = "100";
            
            int i = int.Parse(str); // str = "100h" getting error 'Input string was not in a correct format.'

            string str1 = "200h";
            int j = 0;
            bool isCheckconvert =  int.TryParse(str1, out j);

            Console.WriteLine("value of Parse {0} and tryParse {1} \nisCheckConverstion {2}",i,j,isCheckconvert);
            Console.ReadKey();
        }
    }
}
