using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Ex25_29_for
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ex29();
        }

        static void Ex25()
        {
            Console.WriteLine("Quantas pessoas tem na turma");
            int qtdePessoas = int.Parse(Console.ReadLine());
            int[] idade = new int[qtdePessoas];


            for (int i = 0; i < idade.Length; i++)
            {
                Console.WriteLine($"\nIdade {i + 1}:");
                idade[i] = int.Parse(Console.ReadLine());

            }



            double media = idade.Average();
            if (media <= 25) Console.WriteLine("\nTurma Jovem");
            else if (media <= 60) Console.WriteLine("Turma Adulta");
            else Console.WriteLine("Turma Idosa");


            //Ex25_Faça um programa que peça para as pessoas a sua idade, ao final o programa deverá verificar se a
            //média de idade da turma varia entre 0 e 25,26 e 60 e maior que 60; e então, dizer se a turma é jovem,
            //adulta ou idosa, conforme a média calculada.
        }

        static void Ex26()
        {
            Console.WriteLine("Qual é número total de eleitores:");
            int qtdeEleitores = int.Parse(Console.ReadLine());
            int[] votos = new int[3];



            //Numa eleição existem três candidatos.Faça um programa que peça o número total de eleitores. Peça
            //para cada eleitor votar e ao final mostrar o número de votos de cada candidato.


            for (int i = 0; i < qtdeEleitores; i++)
            {
                Console.WriteLine("Escolha o seu candidato\n");
                Console.WriteLine("1 - Candidato: João Maria");
                Console.WriteLine("2 - Candidato: José Ferreira");
                Console.WriteLine("3 - Candidato: João Guedes\n");

                Console.WriteLine("Digite a opção: ");
                int voto = int.Parse(Console.ReadLine());

                votos[voto - 1]++;

                Console.WriteLine("Voto realizado com sucesso!\n");
            }


            Console.WriteLine("Resultado votação: \n");
            Console.WriteLine("João Maria {0}", votos[0]);
            Console.WriteLine("José Ferreira {0}", votos[1]);
            Console.WriteLine("João Guedes {0}", votos[2]);
        }

        static void Ex27()
        {
            Console.WriteLine("Qual é a quantidade de turmas:");
            int qtdeDeTurma = int.Parse(Console.ReadLine());
            int[] turmas = new int[qtdeDeTurma];

            double soma = 0;

            for (int i = 0; i < qtdeDeTurma; i++)
            {

                int qtdeAlunos;
                string invalid = "A turma não pode ter mais de 40 alunos, digite novamente:";

                do
                {
                    Console.WriteLine($"Quantos alunos tem na turma {i + 1}:");
                    qtdeAlunos = int.Parse(Console.ReadLine());

                    if (qtdeAlunos <= 40) soma += qtdeAlunos;

                    else
                    {
                        Console.WriteLine($"{invalid}\n");
                    }


                } while (qtdeAlunos > 40);
            }

            double media = soma / qtdeDeTurma;
            Console.WriteLine($"\nA média é: {media}");

            //Faça um programa que calcule o número médio de alunos por turma. Para isto, peça a quantidade de
            //turmas e a quantidade de alunos para cada turma. As turmas não podem ter mais de 40 alunos.
        }

        static void Ex28()
        {
            Console.WriteLine("Qual é a quantidade de cd's da sua coleção:");
            int qtdeDeCds = int.Parse(Console.ReadLine());
            int[] cds = new int[qtdeDeCds];

            double soma = 0;

            for (int i = 0; i < qtdeDeCds; i++)
            {
                Console.WriteLine($"Quanto custou o cd {i + 1}:");
                double precoCd = double.Parse(Console.ReadLine());
                soma += precoCd;
            }
            double media = soma / qtdeDeCds;
            Console.WriteLine($"O valor total investido em sua coleção é: R${soma} e o valor médio gasto " +
                $"em cada um dos cd's foi de: R${media}");

            Console.ReadKey();
        }

        static void Ex29()
        {
            //Console.WriteLine("Quantos itens o cliente está levando:");
            //int qtdeItens = int.Parse(Console.ReadLine());

            double preco = 1.99;
            double total = 0;
            Console.WriteLine();


            for (int i = 1; i <= 50; i++)
            {
                total += preco;
                
                Console.WriteLine($"{i} = {((float)total)}");
            }


            //O Sr. Manoel Joaquim possui uma grande loja de artigos de R $1,99, com cerca de 10 caixas.Para
            //agilizar o cálculo de quanto cada cliente deve pagar, ele desenvolveu uma tabela que contém o número
            //de itens que o cliente comprou e ao lado o valor da conta. Desta forma a atendente do caixa precisa
            //apenas contar quantos itens o cliente está levando e olhar na tabela de preços.Você foi contratado
            //para desenvolver o programa que monta esta tabela de preços, que conterá os preços de 1 até 50
            //produtos, conforme o exemplo abaixo:
            //Lojas Quase Dois - Tabela de preços
            //1 - R$ 1.99
            //2 - R$ 3.98...
            //50 - R$ 99.50
        }
    }
}
