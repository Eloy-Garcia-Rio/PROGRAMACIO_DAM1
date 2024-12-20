﻿namespace Ex7
{
    internal class Program
    {
        /// <summary>
        /// Programa que, mentres el valor entrat per l'usuari no sigui 0, emmagatzema el valor entrat més gran i el més petit.
        /// A l'acabar l'itinerari retorna els valors màxim i mínim entrats.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            const int FI = 0;
            int num, max, min;

            max = int.MinValue;
            min = int.MaxValue;
            num = Convert.ToInt32(Console.ReadLine());

            while (num != FI)
            {
                if (max < num)
                    max = num;

                if (min > num)
                    min = num;

                num = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine($"Número més gran: {max}\nNúmero més petit: {min}");
        }
    }
}
