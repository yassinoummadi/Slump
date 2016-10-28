using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slump
{
    class Program
    {
        static void Main(string[] args)
        {

            /* Övning 1
            Random random = new Random();
            int summa = 0;
            for (int i = 0; i < 11; i++)
            {

                int tal = random.Next(20);
                summa = summa + tal;
                Console.WriteLine(tal);

            }

            Console.WriteLine("Medelvärdet är: " + summa/10 );
            */

            Random random = new Random();

            int tal = 0;
            int[] lada = new int[20];
            
            for (int i = 0; i < 20; i++)
            {
                tal = random.Next(15, 31);
                lada[i] = tal;
                
            }

            Array.Sort(lada);

            for (int y = 0; y < lada.Length; y++)
            {
                Console.WriteLine(lada[y] + " ");
            }

            Console.WriteLine("Medianen är lika med " + ((lada[9]) + (lada[10]))/2);





        }
    }
}
