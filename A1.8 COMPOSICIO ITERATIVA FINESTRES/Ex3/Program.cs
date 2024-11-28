﻿namespace Ex3
{
    internal class Program
    {
        /// <summary>
        /// Programa que cerca si hi ha valls dins d'un fitxer i retorna el resultat.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            const string FILE_1 = "NUMEROS1.TXT";
            const string FILE_2 = "NUMEROS2.TXT";

            int a, b, c;
            bool esVall;
            string linia;
            StreamReader sr;

            Console.WriteLine("Selecciona un fitxer ( 1 | 2 )");
            int selector = Convert.ToInt32(Console.ReadLine());

            if (selector == 1)
                sr = new StreamReader(FILE_1);
            else
                sr = new StreamReader(FILE_2);

            a = 0;
            b = 0;
            c = 0;
            esVall = false;
            linia = sr.ReadLine();

            if (linia != null)
            {
                a = Convert.ToInt32(linia);
                linia = sr.ReadLine();

                if (linia != null)
                {
                    b = Convert.ToInt32(linia);
                    linia = sr.ReadLine();

                    if (linia != null)
                    {
                        c = Convert.ToInt32(linia);
                    }
                }
            }

            while (!esVall && linia != null)
            {
                esVall = b < c && b < a;

                if (!esVall)
                {
                    linia = sr.ReadLine();
                    a = b;
                    b = c;
                    c = Convert.ToInt32(linia);
                }
            }
            sr.Close();

            if (esVall)
                Console.WriteLine($"S'ha trobat un vall: {a} > {b} < {c}");
            else
                Console.WriteLine("No s'ha trobat cap vall.");
        }
    }
}
