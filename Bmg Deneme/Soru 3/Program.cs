using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int studentNumber = 2;

            int totalHeight = 0;

            int totalWeight = 0;

            for (int i = 1; i <= studentNumber; i++)
            {
                Console.Write("Kilo giriniz:");
                int tempWeight = Convert.ToInt32(Console.ReadLine());
                if (tempWeight<700)
                {
                    totalWeight += tempWeight;
                }
                else
                {
                    Console.WriteLine("Eksik veya hatalı  girdiniz !");
                    break;
                }

                Console.Write("Boy giriniz:");
                int tempHeight= Convert.ToInt32(Console.ReadLine());
                if (tempHeight < 400)
                {
                    totalHeight += tempHeight;
                }
                else
                {
                    Console.WriteLine("Eksik veya hatalı boy girdiniz !");
                    break;
                }

               
            }

            Console.WriteLine(totalHeight / studentNumber);

            Console.WriteLine(totalWeight / studentNumber);

            Console.Read();
        }
    }
}
