using System;
using System.Globalization;



/// <summary>
/// fazer um programa para ler um número inteiro positivo N, depois N números quaisquer e armazená-los em um vetor.
/// em seguida, mostrar na tela todos elementos do vetor
/// </summary>

namespace VectorsStruture
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, i;
            double[] vet;

            N = int.Parse(Console.ReadLine());
            vet = new double[N];

            for (i = 0; i <  N; i++)
            {
                vet[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            for (i = 0; i < N; i++)
            {
                Console.WriteLine(vet[i].ToString("F1", CultureInfo.InvariantCulture));
            }
            Console.ReadLine();

        }
    }
}
