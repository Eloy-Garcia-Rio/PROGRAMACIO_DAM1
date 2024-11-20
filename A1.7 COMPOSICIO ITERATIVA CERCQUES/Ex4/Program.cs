namespace Ex4
{
    internal class Program
    {
        /// <summary>
        /// Programa que cerca un número entrat per l'usuari dins del fitxter "NUMEROS.TXT" i retorna si l'ha trobat i en quina línia.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            const string FITXER = "NUMEROS.TXT";

            int numObjectiu, numLinia, numActual;
            bool esTrobat;
            string linia;
            StreamReader sr;

            esTrobat = false;
            numLinia = 0;
            numActual = 0;
            Console.WriteLine("Entra un número a cercar.");
            numObjectiu = Convert.ToInt32(Console.ReadLine());
            sr = new StreamReader(FITXER);
            linia = sr.ReadLine();
            numActual = Convert.ToInt32(linia);

            while (!esTrobat && linia != null)
            {
                esTrobat = numActual == numObjectiu;

                numLinia++;
                linia = sr.ReadLine();
                numActual = Convert.ToInt32(linia);
            }

            sr.Close();

            if (esTrobat)
                Console.WriteLine($"El número {numObjectiu} s'ha trobat a la línia {numLinia}.");
            else
                Console.WriteLine($"El número {numObjectiu} s'ha trobat a la línia -1.");
        }
    }
}
