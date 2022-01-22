using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; 

//Contém tipos que permitem ler e gravar em arquivos e fluxos de dados,
//e tipos que fornecem suporte básico de diretório e arquivo


namespace AprendendoFiles
{
    class Program
    {
        static void Main(string[] args)
        {


            //fluxo de comunicação entre o csharp e o arquivo 

            // StreamWriter escritor = new StreamWriter("teste.txt");

            //StreamWriter  escritor = File.AppendText("teste.txt");

            //escritor.WriteLine("Rodrigo");

            //escritor.Close();

            StreamReader leitor = new StreamReader("teste.txt");

            // string conteudo = leitor.ReadToEnd();
            //  Console.WriteLine(conteudo);

            string linha = "";

            while(linha != null)
            {
                linha = leitor.ReadLine();
                Console.WriteLine(linha);
            }

            leitor.Close();

            Console.WriteLine("Arquivo gerado");
            Console.ReadLine();
        }
    }
}
