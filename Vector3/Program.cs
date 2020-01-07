using System;
using System.Globalization;






/// <summary>
/// vet 06
/// Faca um programa que leia N números reias e armazene-os em um vetor em seguida:
/// Imprimir todos os elementos do vetor
/// mostrar na tela a soma e a média dos elementos do vetor
/// </summary>

namespace Vector3
{
    class Program
    {
        static void Main(string[] args)
        {

            int N;
            double[] A;

            N = int.Parse(Console.ReadLine());
            A = new double [N];

            string[] s = Console.ReadLine().Split(' ');
            for (int i =0; i<N; i++)
            {
                A[i] = double.Parse(s[i], CultureInfo.InvariantCulture);
            }
            for (int i = 0; i<N; i++)
            {
                Console.Write(A[i] + " ");
            }
            Console.WriteLine("");

            double soma = 0.0;
            for (int i = 0; i< N; i++)
            {
                soma = soma + A[i];
            }
            double media = soma / N;

            Console.WriteLine(soma.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadLine();



        }
    }
}
