namespace Ex2
{
    internal class Program
    {
        /// <summary>
        /// Programa que, mentres la línia llegida no sigui buida, porta un recompte dels valors trobats en un fitxer.
        /// A l'acabar l'itinerari retorna la quantitat de línies llegides.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int contador;
            string linia;
            bool esBuit;
            StreamReader sr;

            contador = 0;

            sr = new StreamReader("NUMEROS.TXT");
            linia = sr.ReadLine();
            esBuit = linia == null;

            while (linia != null)
            {
                contador++;
                Console.WriteLine($"Iteració {contador} --> {linia}");
                linia = sr.ReadLine();
            }

            sr.Close();

            if (esBuit)
            {
                Console.WriteLine("El fitxer és buit.");
            }
            else
            {
                Console.WriteLine($"TOTAL MISSATGES: {contador}");
            }

        }
    }
}
