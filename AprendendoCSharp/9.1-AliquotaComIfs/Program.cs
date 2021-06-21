using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._1_AliquotaComIfs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando exercício de Alíquota com Ifs");

            double salario = 2000.95;
            double impostoDeRenda;
            int declaracao;

            if (salario >= 1900 || salario <= 2800)
            {
                impostoDeRenda = 7.5;
                declaracao = 142;
                Console.WriteLine(" O IR é " + impostoDeRenda + "% e pode deduzir na declaração o valor de R$" + declaracao);
            }
            else if (salario > 2800 || salario <= 3750)
            {
                impostoDeRenda = 15;
                declaracao = 350;
                Console.WriteLine(" O IR é " + impostoDeRenda + "% e pode deduzir na declaração o valor de R$" + declaracao);
            }
            else if (salario > 3750 || salario <= 4664.00)
            {
                impostoDeRenda = 22;
                declaracao = 350;
                Console.WriteLine(" O IR é " + impostoDeRenda + "% e pode deduzir na declaração o valor de R$" + declaracao);
            }

                Console.ReadLine();
        }
    }
}
