using System;

namespace Condicional_If_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(mensagem());
            Console.WriteLine("\nEscreva seu nome:");

            string nome = Console.ReadLine();

            Console.WriteLine("\nInforme a sua idade:");

            if (int.TryParse(Console.ReadLine(), out int idadeConvertida))
                Console.WriteLine("\nIdade inválida");
            else
            {
                int idade = idadeConvertida;
                //int idade = int.Parse(Console.ReadLine());

                // Operador Ternário
                string eMaior = idade >= 18 ? "maior" : "menor";

                Console.WriteLine($"\n{nome}, você é {eMaior} de idade!");
                Console.WriteLine($"\nParte 2 - {nome}, você é {(idade >= 18 ? "maior" : "menor")} de idade");
            }
        }

        private static string mensagem()
        {
            return "OIIII";
        }
    }
}
