namespace Ex5
{
    internal class Program
    {
        /// <summary>
        /// Programa que cerca senyals de SOS dins d'un fitxer.
        /// Al final de la cerca retorna el resultat.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            const string FILE_1 = "SOS_NO.TXT";
            const string FILE_2 = "SOS_SI.TXT";
            const string SOS = "... --- ...";

            string linia, morse1, morse2;
            bool esPerill;
            StreamReader sr;

            Console.WriteLine("Selecciona un fitxer ( 1 | 2 )");
            int selector = Convert.ToInt32(Console.ReadLine());

            if (selector == 1)
                sr = new StreamReader(FILE_1);
            else
                sr = new StreamReader(FILE_2);

            morse1 = ".";
            morse2 = ".";

            esPerill = false;
            linia = sr.ReadLine();

            if (linia != null)
            {
                morse1 = linia;
                linia = sr.ReadLine();

                if (linia != null)
                {
                    morse2 = linia;
                }
            }

            while (!esPerill && linia != null)
            {
                esPerill = morse1 == SOS && morse2 == SOS;

                if (!esPerill)
                {
                    linia = sr.ReadLine();
                    morse1 = morse2;
                    morse2 = linia;
                }
            }
            sr.Close();

            if (esPerill)
                Console.WriteLine("Hi ha perill.");
            else
                Console.WriteLine("No hi ha perill.");
        }
    }
}
