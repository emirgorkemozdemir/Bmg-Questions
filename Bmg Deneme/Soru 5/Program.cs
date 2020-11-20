using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = Convert.ToInt32(Console.ReadLine());

            int height = Convert.ToInt32(Console.ReadLine());

            int r = Convert.ToInt32(Console.ReadLine());

            int h = Convert.ToInt32(Console.ReadLine());

            double farmArea = (width * height)/4000;

            double siloArea = Math.PI * r * r * h;

            int result = Convert.ToInt32(farmArea / siloArea);

            Console.WriteLine(result);

            Console.Read();

        }
    }
}
