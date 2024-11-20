namespace Ex3a
{
    internal class Program
    {
        /// <summary>
        /// Programa que comprova si algun dels valors trobats en un fitxer és parell i retorna el resultat.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            const string FILE_NAME = "NUMEROS2.TXT";

            int num;
            string linia;
            bool esParell;
            StreamReader sr;

            esParell = false;
            sr = new StreamReader(FILE_NAME);
            linia = sr.ReadLine();
            num = Convert.ToInt32(linia);

            while (!esParell && linia != null)
            {
                esParell = 1.00 * num % 2 == 0.00;

                linia = sr.ReadLine();
                num = Convert.ToInt32(linia);
            }

            sr.Close();

            if (esParell)
                Console.WriteLine("Hi ha valors parells.");
            else
                Console.WriteLine("No hi ha valors parells.");
        }
    }
}
