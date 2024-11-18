namespace Ex2a
{
    internal class Program
    {
        /// <summary>
        /// Programa que comprova si el primer valor trobat en un fitxer es repeteix i retorna el resultat.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            const string FILE_NAME = "NUMEROS.TXT";

            int primerNum, numLinia;
            string linia;
            bool esRepeteix;
            StreamReader sr;

            sr = new StreamReader(FILE_NAME);
            primerNum = Convert.ToInt32(sr.ReadLine());
            linia = sr.ReadLine();
            numLinia = Convert.ToInt32(linia);

            while (numLinia != primerNum && linia != null)
            {
                linia = sr.ReadLine();
                numLinia = Convert.ToInt32(linia);
            }

            sr.Close();
            esRepeteix = numLinia == primerNum;

            if (esRepeteix)
                Console.WriteLine("El primer número es repeteix.");

            else
                Console.WriteLine("El primer número no es repeteix.");
        }
    }
}
