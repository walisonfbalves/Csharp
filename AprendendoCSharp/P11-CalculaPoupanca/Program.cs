using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11_CalculaPoupanca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 11 - Caculando Taxas de poupança");

            double contaPoupanca = 0;
            double salarioInvestido = 3000;
            int contador = 1;

            while ( contador <= 12)
            {
                salarioInvestido = salarioInvestido + (salarioInvestido * 0.0036);
                contaPoupanca = salarioInvestido;
                Console.WriteLine("Daqui a  " + contador + " meses seu dinheiro será R$ " + contaPoupanca);
                // contador = contador + 1;
                // contador += 1;
                contador++;
            }


            Console.ReadLine();
        }
    }
}
