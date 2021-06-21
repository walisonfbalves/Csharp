using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_CriandoVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Criando variáveis");

            int idade;

            idade = 26;
            Console.WriteLine("Minha idade é: " + idade + " anos");

            idade *= 2;
            Console.WriteLine("O dobro da minha idade é: " + idade + " anos");

            idade = 26;
            idade += 10;
            Console.WriteLine("Daqui a 10 anos estarei com " + idade + " anos");

            idade = 26;
            idade -= 11;
            Console.WriteLine("A onze anos atrás eu estava com " + idade + " anos ");

            idade = 26;
            idade /= 2;
            Console.WriteLine("A metade da minha idade é " + idade + " anos ");

            Console.WriteLine("Arquivo finalizado, pressione enter para sair");
            Console.ReadLine();
        }
    }
}
