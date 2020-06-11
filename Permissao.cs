using System;
namespace tryCath
{
    public class Permissao
    {
        public bool permitir {get; set;}

        public void Autorizar(){
            bool teste = false;
            while(teste == false){   
                Console.WriteLine("Deseja permitir acesso? Digite true ou false");
                try
                {
                    permitir = Boolean.Parse(Console.ReadLine());
                    teste = true;
                }
                catch (Exception)
                {
                    teste = false;
                    System.Console.WriteLine("Erro na aplicação! Dados inválidos!");
                }finally{
                    System.Console.WriteLine("Tente novamente!");
                }
            }
        }
    }
}