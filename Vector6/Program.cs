using System;
using System.Globalization;


/// <summary>
/// exemplo de vetores com objeto de tipo referencia 
/// fazer um programa para ler um numero inteiro N e os dados (nome e preço)
/// de N produtos. Armazene os N produtos em um vetor. em seguida, mostrar o preco medio dos produtos
/// </summary>

namespace Vector6
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            Product[] vect = new Product[N];
            for (int i = 0; i < N; i++)
            {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vect[i] = new Product { Name = name, Price = price };
            }

            double sum = 0.0;
            for(int i = 0; i < N; i++)
            {
                sum += vect[i].Price;
            }

            double avg = sum /N;
            Console.WriteLine("AVERAGE PRICE: " + avg.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}
