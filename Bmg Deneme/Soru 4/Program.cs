using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kübik feet cinsinden satın almak istediğiniz su miktarını giriniz:");
            int cf = Convert.ToInt32(Console.ReadLine());

            double totalPayment = 0;

            if (cf<1000)
            {
                totalPayment = 15;
            }
            else if(cf<2000 && cf>1000)
            {
                totalPayment += 15;
                totalPayment += (2000 - cf) * 0.0175;
            }
            else if (cf < 3000 && cf > 2000)
            {
                totalPayment += 15;
                totalPayment += (3000 - cf) * 0.02;
            }
            else if (cf > 3000)
            {
                totalPayment = 70;
            }

            Console.WriteLine(totalPayment);

            Console.Read();
        }
    }
}
