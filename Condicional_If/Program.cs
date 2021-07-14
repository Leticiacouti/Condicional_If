using System;

namespace Condicional_If
{
    class Program
    {
        static void Main(string[] args)
        {
            const string nomeC = "Leticia";
            const string cabeloC = "Morena";
            const int idadeC = 19;

            Console.WriteLine("Informe o nome da professora");
            string nomeProf = Console.ReadLine();


            Console.WriteLine("Informe a idade dela");
            int idadeProf = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe a cor do cabelo dela");
            string cabeloProf = Console.ReadLine();

            if (nomeC == nomeProf && cabeloC == cabeloProf && idadeC == idadeProf)
                Console.WriteLine("É exatamente ela!");
            else if (nomeC == nomeProf || cabeloC == cabeloProf || idadeC == idadeProf)
                Console.WriteLine("Parece com ela, mas não é ela!");
            else
                Console.WriteLine("Não é ela!");

            //string mensagem = nomeC == nomeProf && cabeloC == cabeloProf && idadeC == idadeProf ? "É exatamente ela!" :
            //  nomeC == nomeProf || cabeloC == cabeloProf || idadeC == idadeProf ? "Parece com ela, mas não é ela!" : "Não é ela!";
        }
    }
}
