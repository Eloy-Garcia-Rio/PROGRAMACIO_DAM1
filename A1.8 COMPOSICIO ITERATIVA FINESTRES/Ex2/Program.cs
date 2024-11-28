namespace Ex2
{
    internal class Program
    {
        /// <summary>
        /// Programa que comprova si tots els valors en un fitxer estan en ordre creixent i retorna el resultat.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            const string FILE_1 = "CREIXENT.TXT";
            const string FILE_2 = "NO_CREIXENT.TXT";

            int numAnterior, numActual;
            bool esCreixent;
            string linia;
            StreamReader sr;

            Console.WriteLine("Selecciona un fitxer ( 1 | 2 )");
            int selector = Convert.ToInt32(Console.ReadLine());

            if (selector == 1)
                sr = new StreamReader(FILE_1);
            else
                sr = new StreamReader(FILE_2);

            numAnterior = 0;
            numActual = 0;
            esCreixent = true;

            linia = sr.ReadLine();

            if (linia != null)
            {
                numAnterior = Convert.ToInt32(linia);
                linia = sr.ReadLine();

                if (linia != null)
                {
                    numActual = Convert.ToInt32(linia);
                }
            }

            while (esCreixent && linia != null)
            {
                esCreixent = numActual > numAnterior;

                if (esCreixent)
                {
                    linia = sr.ReadLine();
                    numAnterior = numActual;
                    numActual = Convert.ToInt32(linia);
                }
            }
            sr.Close();

            if (esCreixent)
                Console.WriteLine("Tots els valors estan en ordre creixent estricte.");
            else
                Console.WriteLine("No tots els valors estan en ordre creixent estricte.");
        }
    }
}
