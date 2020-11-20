using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());

            int mult=1;

            for (int i = 1; i <= number; i++)
            {
                mult *= i;
            }

            Console.WriteLine(mult);

            Console.Read();

            
        }
    }
}
