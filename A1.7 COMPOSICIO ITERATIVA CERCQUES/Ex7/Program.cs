namespace Ex7
{
    internal class Program
    {
        /// <summary>
        /// Programa que cerca un número dins d'un fitxer.
        /// Al final de la cerca, retorna si ha estat trobat o no i, en cas de ser trobat, en quina línia.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            const string FILE_1 = "PERDUT.TXT";
            const string FILE_2 = "TROBAT.TXT";

            int dorsal, posicio;
            bool esTrobat;
            string linia;
            StreamReader sr;

            Random rnd = new Random();
            int selector = rnd.Next(1, 3);  

            esTrobat = false;
            posicio = 0;

            if (selector == 1)
                sr = new StreamReader(FILE_1);
            else 
                sr = new StreamReader(FILE_2);

            linia = sr.ReadLine();

            while (!esTrobat && linia != null)
            {
                dorsal = Convert.ToInt32(linia);
                posicio++;

                esTrobat = dorsal == 231;

                linia = sr.ReadLine();
            }
            sr.Close();

            if (esTrobat)
                Console.WriteLine($"El dorsal 231 ha arribat en posició {posicio}");
            else
                Console.WriteLine("El dorsal 231 no ha arribat.");
        }
    }
}
