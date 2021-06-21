using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_CriandoUmPontoFlutuante
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto 3 - Criando um ponto flutuante");

            double salario;
            salario = 2000.95;
            Console.WriteLine("Meu salário atual é: " + salario);

            double idade;
            idade = 23 / 2;
            Console.WriteLine("23 / 2 = " + idade);

            idade = 23.0 / 2;
            Console.WriteLine("23.0 / 2 = " + idade);

            Console.ReadLine();
            

        }
    }
}
