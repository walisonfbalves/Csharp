using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CaracteresETextos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 5 - Caracteres e Textos");

            char letra = 'a';
            Console.WriteLine(letra);
            // Para ver a numeração dos chacteres pesquise Ascii table no google.
            letra = (char)65;
            Console.WriteLine(letra);

            letra = (char)(letra + 1);
            Console.WriteLine(letra);

            string titulo = "Curso Alura";
            Console.WriteLine(titulo);

            string cursosAlura =
@"- .NET
- JavaScript
- HTTP";
            Console.WriteLine(cursosAlura);

            Console.ReadLine();

        }
    }
}
