﻿namespace Ex15
{
    internal class Program
    {
        /// <summary>
        /// Programa que genera un quadrat amb asteriscs d'alçada indicada per l'usuari.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int num;

            Console.WriteLine("Entra un número.");
            num = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < num * num; i++)
            {
                
                if (i % num == 0 && i != 0)
                {
                    Console.WriteLine(" ");
                }

                Console.Write('*');
            }
        }
    }
}
