using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprendendoListas
{
    class Program
    {
        static void Main(string[] args)
        {

            // System.Linq permiti filtrar, fazer remoção  e buscar nas listas 

            List<string> clientes = new List<string>();
            clientes.Add("Mariana"); 
            clientes.Add("Lima");
            clientes.Add("Lua");
            clientes.Add("Rodrigo");
            string pessoa = "João";

            clientes.Add(pessoa);


           /* foreach (string cliente in clientes) 
            {
                Console.WriteLine(cliente);
            }

            //clientes.RemoveAt(2);

            clientes.RemoveAll(cliente => cliente == "Lima");
           */

            foreach (string cliente in clientes)
            {
                Console.WriteLine(cliente);
            }


            Console.WriteLine("=============");

            // string busca = clientes.Find(cliente => cliente.Length < 5);

            List<string> filtrada = clientes.FindAll(cliente => cliente.Length < 5);


            Console.WriteLine("=============");

           foreach (string cliente in filtrada)
            {
                Console.WriteLine(cliente);
            }

            //Console.WriteLine(busca);
            Console.ReadLine();

        }
    }
}
