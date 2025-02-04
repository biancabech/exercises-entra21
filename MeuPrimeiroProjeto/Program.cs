using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuPrimeiroProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Exercicio13();
            Exercicio1();
        }
        static void Exercicio1()
        {
            Console.WriteLine("Base:");
            double baseRetangulo = double.Parse(Console.ReadLine());

            Console.WriteLine("\nAltura:");
            double altura = double.Parse(Console.ReadLine());

            //O perímetro de um retângulo é calculado somando as medidas de todos os seus lados. 
            //Formula: P=2(b+h)

            double perimetro = 2 * (altura + baseRetangulo);

            //Para a realização usamos a fórmula da área A = b. h, assim um de seus lados será a base (b) e o outro a altura (h).
            double area = baseRetangulo * altura;

            Console.WriteLine($"Perimetro:{perimetro}");
            Console.WriteLine($"Area:{area}");
        }

        static void Exercicio13()
        {
            Console.WriteLine("\nQuantos anos faz que você fuma?");
            double anosFumando = double.Parse(Console.ReadLine());

            Console.WriteLine("\ncigarrosFumadosDia: "); 
            double cigarrosFumadosDia = double.Parse(Console.ReadLine());

            Console.WriteLine("\nQuanto custa um maço de cigarro:");
            double carteira = double.Parse(Console.ReadLine());

            double totalCigarrosFumadosAno = (anosFumando * 365) * cigarrosFumadosDia;
            double valorTotalGasto = totalCigarrosFumadosAno * (carteira / 20);

            Console.WriteLine($"Total gasto em cigarros:{valorTotalGasto} reais");
            
        }
    }
}
