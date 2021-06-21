using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6___AtribuicoesDeVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 6");

            int idade = 26;
            int idadeWalison = idade;

            idade = 35;

            Console.WriteLine(idade);
            Console.WriteLine(idadeWalison);

            Console.ReadLine();
        }
    }
}
