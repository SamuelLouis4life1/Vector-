using System;



// fazer um programa para ler um valor N e depois o nome de N pessoas.
// em seguida, mostrar os nomes lidos.


/// <summary> o mesmo exemplo usando foreach
/// foreach (string elemento in vet)
/// {
///     Console.WriteLine(elemento);
/// }
/// </summary>

namespace ForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            N = int.Parse(Console.ReadLine());
            string[] vet = new string[N];

            for (int i = 0; i < N; i++)
            {
                vet[i] = Console.ReadLine();
            }

            Console.WriteLine("Nomes lidos: ");
            for (int i = 0; i<N; i++)
            {
                Console.WriteLine(vet[i]);
            }
               Console.ReadLine();
        }
    }
}
