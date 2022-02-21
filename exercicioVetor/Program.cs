using System;
using System.Globalization;

namespace exercicioVetor
{
    class Program
    {
        static void Main(string[] args)
        {

            Quarto[] vect = new Quarto[10];
            Console.WriteLine("Olá informe o número de quartos: ");

            int n = int.Parse(Console.ReadLine());

         

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Aluguel #{i}:");
                Console.WriteLine("Nome: ");
                string nome = Console.ReadLine();
                Console.WriteLine("Eamil: ");
                string email = Console.ReadLine();
                Console.WriteLine("quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                vect[quarto] = new Quarto ( nome , email );

            }

            Console.WriteLine();
            Console.WriteLine("quartos ocupados: ");
            for(int i = 0; i < 10; i++)
            {
                if(vect[i] != null)
                {
                    Console.WriteLine(i + ": " + vect[i]);
                }
            }











        }
    }
}
