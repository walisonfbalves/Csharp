using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Condicionais2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 8 - Condicionais 2");

            int idadeAluno = 17;
            bool acompanhante = true;

            if (idadeAluno >= 18 || acompanhante == true)
            {
                Console.WriteLine("Pode entrar");
            }
            else
            {
                Console.WriteLine("Proibida a entrada. Precisa ter no mínimo 18 anos ou está acompanhado de um responsável");
            }

            if (idadeAluno >= 18 && acompanhante == false)
            {
                Console.WriteLine("Pode entrar");
            }
            else
            {
                Console.WriteLine("Proibida a entrada. Precisa ter no mínimo 18 anos ou está acompanhado de um responsável");
            }

            Console.ReadLine();
        }
    }
}
