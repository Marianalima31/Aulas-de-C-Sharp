using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConversoesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 4");

            double salario;
            salario = 12000.70;

            int salarioInteiro;
            salarioInteiro = (int)salario;
            Console.WriteLine(salarioInteiro);

            // O int é um tipo de variavel que suporta 32 bits
            // long é uma variavel de 64 bits
            // short é uma variavel de 16 bits


            short quantidadeProdutos;
            quantidadeProdutos = 15000;
            Console.WriteLine(quantidadeProdutos);

            float altura = 1.80f;
            Console.WriteLine(altura);


            Console.ReadLine();


         }
    }
}
