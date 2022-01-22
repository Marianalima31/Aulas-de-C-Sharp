using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprendendoStructs
{
    class Program
    {
        struct Produto
        {
            public string nome;
            public double preco;
            public double peso;
            public string marca;

            public Produto(string nome, double preco, double peso, string marca)
            {
                this.nome = nome; //Variavel do atributo  = (recebe) A variavel do parametro                             
                this.preco = preco;
                this.peso = peso;
                this.marca = marca;
            }

           public void ExibirInfo()
            {
                Console.WriteLine($"Nome: { nome} ");
                Console.WriteLine($"Preço: R$ { preco }");
                Console.WriteLine($"Peso: { peso} kg");
                Console.WriteLine($"Marca: { marca}");
            }

            public double adicionarCupom(double porc)
            {
                double desconto = this.preco * porc / 100;
                return this.preco - desconto;
            }

        }
        static void Main(string[] args)
        {

            Produto bola = new Produto("bola de volei",150,1,"nike");



            bola.ExibirInfo();

            double valorFinal = bola.adicionarCupom(40);
            Console.WriteLine("Valor final com desconto: " + valorFinal);
            Console.ReadLine();
      
        }
    }
}
