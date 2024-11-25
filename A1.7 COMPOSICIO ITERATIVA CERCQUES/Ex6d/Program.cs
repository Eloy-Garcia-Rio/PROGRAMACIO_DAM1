namespace Ex6d
{
    internal class Program
    {
        /// <summary>
        /// Programa que cerca números primers dins d'un fitxer i retorna el resultat.
        /// </summary>
        /// <param name="args"></param>
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

            while (!esPrimer && linia != null)
            {
                esPrimer = EsPrimer(num);

                linia = sr.ReadLine();
                num = Convert.ToInt32(linia);
            }

            sr.Close();

            if (esPrimer)
                Console.WriteLine("Hi ha algun número primer.");
            else
                Console.WriteLine("No hi ha cap número primer.");

        }

        /// <summary>
        /// Funció que comprova si el número passat és primer.
        /// </summary>
        /// <param name="n">Número passat.</param>
        /// <returns>Booleana indicant si és primer.</returns>
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
