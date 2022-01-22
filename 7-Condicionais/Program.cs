using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 7");

            int idadeJoao = 15;
            int quantidadePessoas = 0;

            if (idadeJoao >= 18)

            {
                Console.WriteLine("João possui mais de 18 anos de idade. Pode Entrar");
            }
            else
            {
                if (quantidadePessoas >= 1)
                {
                    Console.WriteLine("João Não possui mais de 18 naos, mas está acompanhado. Pode Entrar !");
                }
                else
                {
                    Console.WriteLine("João pode possui mais de 18 anos, não pode entrar");
                }

            }


            Console.ReadLine();
        }
    }
}
