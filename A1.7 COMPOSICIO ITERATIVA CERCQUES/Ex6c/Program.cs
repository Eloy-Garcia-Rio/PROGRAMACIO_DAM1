﻿namespace Ex6c
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string FILE = "ALGUNSPRIMERS.TXT";

            int num;
            bool esPrimer;
            string linia;
            StreamReader sr;

            esPrimer = false;
            sr = new StreamReader(FILE);
            linia = sr.ReadLine();
            num = Convert.ToInt32(linia);

            while (linia != null)
            {
                esPrimer = EsPrimer(num);

                if (esPrimer)
                    Console.WriteLine($"El número {num} és primer.");
                else
                    Console.WriteLine($"El número {num} no és primer.");

                linia = sr.ReadLine();
                num = Convert.ToInt32(linia);
            }
        }

        public static bool EsPrimer(int n)
        {
            int sum, inc;
            bool isPrime;
            sum = 0;
            inc = 1;
            isPrime = false;

            while (!isPrime && inc <= n)
            {
                if (n % inc == 0)
                    sum = sum + inc;

                if (n == 1)
                    isPrime = true;
                else
                {
                    isPrime = sum == n + 1;
                }

                inc++;
            }

            return isPrime;
        }
    }
}
