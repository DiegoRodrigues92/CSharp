using System;
namespace EntradaDeDados
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Qual é o seu nome?");
            string nomePessoa = Console.ReadLine();

            Console.Write("Qual a sua idade? ");
            int idade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Seu nome é: " + nomePessoa + ", minha idade é " + idade + " anos.");

            Console.ReadLine(); 
           

            


        }




    }
}