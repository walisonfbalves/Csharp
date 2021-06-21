using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConversoesEOutrosTiposDeNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("4 - Covertendo numeros");

            // Int é um numero de 32 bits ou seja armazena até uma certa quantidade de um numero.
            int numero = 100000000;
            Console.WriteLine(numero);

            // Long é um variável de 64 bits 
            long idadeTerra = 10000000000;
            Console.WriteLine(idadeTerra);

            // Short é uma variável de 16 bits 
            short idadeMinha = 10000;
            Console.WriteLine(idadeMinha);

            //Convertendo um double em um int
            double idade = 15.5;
            int idadeInteira = (int)idade;
            Console.WriteLine(idadeInteira);

            // Menos usual, o float é para um número menor, e precisa do sufixo f para ser aceito.
            float numeroFloat = 1.77f;
            Console.WriteLine("O número float é: " + numeroFloat);

            Console.ReadLine();
        }   
    }
}
