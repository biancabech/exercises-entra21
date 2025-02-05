using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calcular();
        }

        static void Calcular()
        {
            Console.WriteLine("Digite qual é a tabuada que você que: ");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{numero} x {i} = {numero* i}"); 
            }
        }
    }
}
