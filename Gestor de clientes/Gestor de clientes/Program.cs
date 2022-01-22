using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestor_de_clientes
{
    class Program
    {
       struct Cliente
        {
            public string nome;
            public string email;
            public string cpf;
        }

        static List<Cliente> clientes = new List<Cliente>();
        enum Menu { Listagem = 1, Adicionar = 2, Remover = 3, Sair = 4}
        static void Main(string[] args)
        {
            bool escolheuSair = false;

            Console.WriteLine("Sistema de Clientes - Seja Bem Vindo");
            Console.WriteLine("1-Listagem \n2-Adicionar \n3-Remover \n4-Sair ");
            int intOP = int.Parse(Console.ReadLine());
            Menu opcao = (Menu)intOP; 

            switch (opcao)
                {
                case Menu.Adicionar:
                    Adicionar();
                    break;
                case Menu.Listagem:
                    break;
                case Menu.Remover:
                    break;
                case Menu.Sair:
                    escolheuSair = true;
                    break;
                }

            Console.Clear();

        }

        static void Adicionar()
        {
            Cliente cliente = new Cliente();
            Console.WriteLine("Cadastro de Cliente  ");
            Console.WriteLine("Nome do Cliente: " );
            cliente.nome = Console.ReadLine();
            Console.WriteLine("Email do Cliente: ");
            cliente.email = Console.ReadLine();
            Console.WriteLine("CPF do Cliente: ");
            cliente.cpf = Console.ReadLine();

            clientes.Add(cliente);


            Console.WriteLine("Cadastro concluido com sucesso! aperter enter para sair");
            Console.ReadLine();
        }

        static void Listagem()
        {

            if (clientes.Count > 0) 
            {

                Console.WriteLine("Lista de Clientes");
                int i = 0;

                foreach (Cliente cliente in clientes)
                {
                    Console.WriteLine($"ID: {i}");
                    Console.WriteLine($"Nome: {cliente.nome}");
                    Console.WriteLine($"Email: {cliente.email}");
                    Console.WriteLine($"CPF: {cliente.cpf}");
                    Console.WriteLine("==================================================");
                    i++;
                }
               
            }

            else
            {
                Console.WriteLine("No momento não há nenhum cliente cadastrado");
            }

            Console.WriteLine("Aperte enter para sair");
            Console.ReadLine();
         }

        static void Salvar()
        {
            FileStream stream = new FileStream("Clientes.dat", FileMode.OpenOrCreate);


        }

           

    }

   }
