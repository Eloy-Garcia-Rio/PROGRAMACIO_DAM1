namespace ValidacioA1._7
{
    internal class Program
    {
        /// <summary>
        /// Programa que cerca un vaixell anomenat "TITANIC" dins d'un fitxer.
        /// A l'acabar la cerca, retorna si l'ha trobat o no.
        /// En cas positiu, el retorn inclou les coordenades corresponents.
        /// En cas negatiu, el retorn inclou la quantitat de naus trobades.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            const string FILE_1 = "BARCOS1.TXT";
            const string FILE_2 = "BARCOS2.TXT";

            int nVaixells;
            double latitud, longitud;
            string linia, nomVaixell;
            bool esTitanic;
            StreamReader sr;

            // Selector de fitxers.

            Console.WriteLine("Selecciona un fitxer ( 1 | 2 )");
            int selector = Convert.ToInt32(Console.ReadLine());
            
            if(selector == 1)
                sr = new StreamReader(FILE_1);
            else 
                sr = new StreamReader(FILE_2);

            // Inicialització de variables.

            nVaixells = 0;
            latitud = 0;
            longitud = 0;
            esTitanic = false;
            linia = sr.ReadLine();

            // Cerca i tractament d'elements.

            while (!esTitanic && linia != null)
            {
                nomVaixell = linia;
                latitud = Convert.ToDouble(sr.ReadLine());
                longitud = Convert.ToDouble(sr.ReadLine());

                esTitanic = nomVaixell == "TITANIC";

                if (!esTitanic)
                {
                    nVaixells++;
                    linia = sr.ReadLine();
                }
            }
            sr.Close();

            // Retorn final.

            if (esTitanic)
                Console.WriteLine($"Titanic trobat en coordenades ({latitud} , {longitud}).");
            else
                Console.WriteLine($"Trobats {nVaixells} barcos enfonsats, però cap és el Titanic.");
        }
    }
}
