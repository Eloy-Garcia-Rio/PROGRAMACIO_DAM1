namespace Ex6
{
    internal class Program
    {
        /// <summary>
        /// Programa que, mentres la línia llegida del fitxer no sigui buida, porta un recompte dels valors trobats en un fitxer i fa mitjana dels valors.
        /// A l'acabar l'itinerari retorna la mitjana de tots els valors.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int num, sumatori, contador;
            double mitjana;
            string linia;
            bool esBuit;
            StreamReader sr;

            contador = 0;
            sumatori = 0;

            sr = new StreamReader("NUMEROS2.TXT");
            linia = sr.ReadLine();
            esBuit = linia == null;

            while (linia != null)
            {
                num = Convert.ToInt32(linia);
                contador++;
                sumatori = sumatori + num;
                linia = sr.ReadLine();
            }

            sr.Close();

            if (esBuit)
            {
                Console.WriteLine("El fitxer és buit.");
            }
            else
            {
                mitjana = 1.00 * sumatori / contador;
                Console.WriteLine($"Mitjana: {mitjana}");
            }

        }
    }
}
