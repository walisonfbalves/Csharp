using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Escopo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 8 - Condicionais 2");

            int idadeAluno = 17;
            bool acompanhante = true;
            string mensagemaAdicional;

            if (acompanhante == true)
            {
                mensagemaAdicional = "Está acompanhado";
            }
            else
            {
                mensagemaAdicional = "Não está acompanhado ou é menor de idade.";
            }


            if (idadeAluno >= 18 || acompanhante == true)
            {
                Console.WriteLine("Pode entrar");
                Console.WriteLine(mensagemaAdicional);
            }
            else
            {
                Console.WriteLine("Proibida a entrada.");
                Console.WriteLine(mensagemaAdicional);
            }

            Console.ReadLine();
        }
    }
}
