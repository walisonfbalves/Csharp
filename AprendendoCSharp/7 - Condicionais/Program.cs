using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7___Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 7 - Condicionais");

            int idadeAluno = 17;
            int idadeAcompanhante = 20;
            
            if(idadeAluno >= 18)
            {
                Console.WriteLine("Pode entrar");
            } 
            else
            {
                if (idadeAcompanhante >= 18)
                {
                    Console.WriteLine("É menor de idade, porém está acompanhado de um maior de idade. Pode entrar");
                }
                else
                {
                    Console.WriteLine("Proibida a entrar. Precisa ter no mínimo 18 anos ou está acompanhado de um responsável");
                }
            }

            Console.ReadLine();
        }
    }
}
