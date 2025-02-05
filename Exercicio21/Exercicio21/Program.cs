using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor do saque");
            int saque = int.Parse(Console.ReadLine());
            int aux = saque;

            int notasCem = aux / 100;
            aux -= notasCem * 100;

            int notasCinquenta = aux / 50;
            aux -= notasCinquenta * 50;

            int notasVinte = aux / 20;
            aux -= notasVinte * 20;

            int notasDez = aux / 10;
            aux -= notasDez * 10;

            int notasCinco = aux / 5;
            aux -= notasCinco * 5;

            int notasUm = aux / 1;
            aux -= notasUm * 1;

            Console.WriteLine($"Você irá sacar as seguintes quantidades de notas:\n");


            Console.WriteLine($"Notas de 100: {notasCem} \nNotas de 50: {notasCinquenta} \nNotas de 20: {notasVinte} \nNotas de 10: {notasDez} \nNotas de 05: {notasCinco} \nNotas de 01: {notasUm} ");
        }
    }
}
