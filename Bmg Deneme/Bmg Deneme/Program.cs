using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bmg_Deneme
{
    class Program
    {
        static void Main(string[] args)
        {
            int negative = 0;
            int positive = 0;
            int zero = 0;

            for (int i = 1; i <= 3; i++)
            {
                int tempNumber = Convert.ToInt32(Console.ReadLine());

                if (tempNumber>0)
                {
                    positive += 1;
                }
                else if (tempNumber<0)
                {
                    negative += 1;
                }
                else
                {
                    zero += 1;
                }

            }

            Console.WriteLine(negative);
            Console.WriteLine(positive);
            Console.WriteLine(zero);

            Console.Read();
        }
    }
}
