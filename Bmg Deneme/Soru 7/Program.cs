using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru_7
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 - 2- 3 - 4 -5 -6 -7 -8 -9 //

            int start = Convert.ToInt32(Console.ReadLine());
            int finish = Convert.ToInt32(Console.ReadLine());

            int passangerNum = Convert.ToInt32(Console.ReadLine());

            double total = 0;

            double totalDiscount = 0;

            if (passangerNum>=3)
            {
                int difference = finish - start;
                if (difference < 0)
                {
                    difference *= -1;
                }
                total = difference * 2;
                totalDiscount = total * 1 / 10;
                total = total - totalDiscount;
            }
            else
            {
                int difference = finish - start;
                if (difference<0)
                {
                    difference*=-1;
                }
               
                total = difference * 2;
            }

            Console.WriteLine(total);
            Console.WriteLine(totalDiscount);

            Console.Read();
        }
    }
}
