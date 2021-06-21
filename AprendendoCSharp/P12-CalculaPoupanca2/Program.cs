using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P12_CalculaPoupanca2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 12 - Loop FOR");

            double valorInvestido = 1000;

            for (int contador = 1; contador <= 12; contador++)
            {
                valorInvestido = valorInvestido * 1.0036;
                Console.WriteLine("Após " + contador + " meses, o valor será R$" + valorInvestido);
            }


            Console.ReadLine();
        }
    }
}
