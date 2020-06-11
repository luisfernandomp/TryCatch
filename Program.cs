using System;
using System.IO;
namespace tryCath
{
    class Program
    {
        static void Main(string[] args)
        {
            Permissao p = new Permissao();
            p.Autorizar();
            System.Console.WriteLine("Digite um texto: ");
            string texto = Console.ReadLine();

            // Instância da classe para gravar arquivos de texto
            StreamWriter escritor = new StreamWriter("texto.txt");
            escritor.WriteLine(texto); // Escreve  a linha

            escritor.Close(); //Fecha a instância

            StreamReader leitor = new StreamReader("texto.txt");
            string lido = leitor.ReadToEnd();
            Console.WriteLine(lido);
            Console.WriteLine("Arquivo gerado!");

            Console.ReadKey();

            try{
                using(StreamReader sr = File.OpenText("data.txt.txt")) 
                // Usando o using não é necessário abrir e fechar o arquivo
                {
                    System.Console.WriteLine($"A primeira linha do arquivo é: \n {sr.ReadLine()}"); 
                }
            }catch (FileNotFoundException){
                System.Console.WriteLine($"O arquivo não foi encontrado");
            }catch(DirectoryNotFoundException){
                System.Console.WriteLine($"O diretório não foi encontrado");
            }catch(IOException){
                System.Console.WriteLine($"O arquivo não pôde ser encontrado");
            }
        }
    }
}
