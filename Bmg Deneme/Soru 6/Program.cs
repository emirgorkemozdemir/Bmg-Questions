using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = 1;

            int second = 1;

            int temp = 0;
            Console.WriteLine(first);

            Console.WriteLine(second);


            for (int i = 0; i < 50; i++)
            {
                temp = first + second;
                first = second;
                second = temp;
              
                Console.WriteLine(temp);
            }

            Console.Read();
        }
    }
}
