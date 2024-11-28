namespace Ex1
{
    internal class Program
    {
        /// <summary>
        /// Programa que cerca un valor que sigui la suma dels dos anteriors dins d'un fitxer i retorna el resultat.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            const string FILE_1 = "NUMEROS1.TXT";
            const string FILE_2 = "NUMEROS2.TXT";

            int numUltim, numPrevi, numActual;
            bool esSuma;
            string linia;
            StreamReader sr;

            Console.WriteLine("Selecciona un fitxer ( 1 | 2 )");
            int selector = Convert.ToInt32(Console.ReadLine());

            if (selector == 1)
                sr = new StreamReader(FILE_1);
            else
                sr = new StreamReader(FILE_2);

            numUltim = 0;
            numPrevi = 0;
            numActual = 0;

            esSuma = false;
            linia = sr.ReadLine();

            if(linia != null)
            {
                numUltim = Convert.ToInt32(linia);
                linia = sr.ReadLine();

                if (linia != null)
                {
                    numPrevi = Convert.ToInt32(linia);
                    linia = sr.ReadLine();

                    if (linia != null)
                        numActual = Convert.ToInt32(linia);
                }
            }

            while (!esSuma && linia != null)
            {
                esSuma = numActual == numUltim + numPrevi;

                if (!esSuma)
                {
                    linia = sr.ReadLine();
                    numUltim = numPrevi;
                    numPrevi = numActual;
                    numActual = Convert.ToInt32(linia);
                }
            }
            sr.Close();

            if (esSuma)
                Console.WriteLine($"S'ha complert la condició. {numUltim} + {numPrevi} = {numActual}");
            else
                Console.WriteLine("No s'ha complert la condició.");
        }
    }
}
