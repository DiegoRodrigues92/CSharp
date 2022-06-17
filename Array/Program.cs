using System;
namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] carros = { "Fox", "Gol", "Fusca" };
            int[] numeros = {1, 2, 3 };
            carros[2] = "Brasilia";
            //Console.WriteLine(carros.Length);
            for (int i = 0; i < carros.Length; i++)
            {
                Console.WriteLine(carros[i]);

            }



            Console.ReadLine();


        }

    }
}