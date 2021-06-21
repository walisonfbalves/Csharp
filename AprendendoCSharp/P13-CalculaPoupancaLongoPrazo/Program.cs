using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P13_CalculaPoupancaLongoPrazo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 13");

            double fatorInvestimento = 1.0036;
            double valorInvestido = 1000;

            for (int contador = 1; contador <= 5; contador++)
            {
                for(int contadorMes = 1; contadorMes <= 12; contadorMes++)
                {
                    valorInvestido *= fatorInvestimento;
                }
                fatorInvestimento += 0.0010;
            }

            Console.WriteLine("O valor no final do investimento será R$" + valorInvestido);

            Console.ReadLine();
        }
    }
}
