namespace Ex6
{
    internal class Program
    {
        /// <summary>
        /// Programa que, mentres la línia llegida no sigui buida, porta un recompte dels valors trobats en un fitxer i fa mitjana dels valors.
        /// A l'acabar l'itinerari retorna la mitjana de tots els valors.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int num, sumatori, contador;
            double mitjana;
            string linia;
            StreamReader sr;

            contador = 0;
            sumatori = 0;
            sr = new StreamReader("NUMEROS2.TXT");
            linia = sr.ReadLine();
            num = Convert.ToInt32(linia);

            while (linia != null)
            {
                contador = contador + 1;
                sumatori = sumatori + num;
                linia = sr.ReadLine();
                num = Convert.ToInt32(linia);
            }

            sr.Close();
            mitjana = 1.00 * sumatori / contador;
            Console.WriteLine($"Mitjana: {mitjana}");
        }
    }
}
