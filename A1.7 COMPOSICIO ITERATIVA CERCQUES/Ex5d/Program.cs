namespace Ex5d
{
    internal class Program
    {
        /// <summary>
        /// Programa que cerca números perfectes dins d'un fitxer i retorna el resultat.
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

            while (!esPerfecte && linia != null)
            {
                esPerfecte = EsPerfecte(num);

                linia = sr.ReadLine();
                num = Convert.ToInt32(linia);
            }

            sr.Close();

            if (esPerfecte)
                Console.WriteLine("Hi ha algun número perfecte");
            else
                Console.WriteLine("No hi ha cap número perfecte");

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
