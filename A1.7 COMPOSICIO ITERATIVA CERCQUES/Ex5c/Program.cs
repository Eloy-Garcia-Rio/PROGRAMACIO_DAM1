namespace Ex5c
{
    internal class Program
    {
        /// <summary>
        /// Programa que retorna si els valors d'un fitxer són números perfectes o no.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            const string FILE = "PERFECTES.TXT";

            int num;
            bool esPerfecte;
            string linia;
            StreamReader sr;

            esPerfecte = false;
            sr = new StreamReader(FILE);
            linia = sr.ReadLine();
            num = Convert.ToInt32(linia);

            while (linia != null)
            {
                esPerfecte = EsPerfecte(num);

                if (esPerfecte)
                    Console.WriteLine($"El número {num} és perfecte.");
                else
                    Console.WriteLine($"El número {num} no és perfecte.");

                linia = sr.ReadLine();
                num = Convert.ToInt32(linia);
            }
        }

        /// <summary>
        /// Funció que comprova si el número passat és perfecte.
        /// </summary>
        /// <param name="n">Número passat.</param>
        /// <returns>Booleana indicant si és perfecte.</returns>
        public static bool EsPerfecte(int n)
        {
            int sum, inc;
            bool isPerf;
            sum = 0;
            inc = 1;
            isPerf = false;

            while (!isPerf && inc <= n / 2)
            {
                if (n % inc == 0)
                    sum = sum + inc;

                isPerf = sum == n;
                inc++;
            }

            return isPerf;
        }
    }
}
