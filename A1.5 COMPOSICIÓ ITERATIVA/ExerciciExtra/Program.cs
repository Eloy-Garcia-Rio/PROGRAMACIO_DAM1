namespace ExerciciExtra
{
    internal class Program
    {
        /// <summary>
        /// Programa que, a partir dels valors trobats en el fitxer "CURSA.TXT", calcula i retorna el total de segons que cada dorsal d'una cursa ha necessitat per completar-la.
        /// Addicionalment, determina quins han estat els dorsals amb el millor i pitjor temps respectivament.
        /// Al final de l'itinerari, el programa retorna el millor i el pitjor resultat en segons amb el seu dorsal corresponent.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int hhMMss, dorsal, tempsMillor, tempsPitjor;
            int h, m, s, segons, millorDorsal, pitjorDorsal;
            string linia;
            StreamReader sr;

            hhMMss = 0;
            dorsal = 0;
            segons = 0;
            millorDorsal = 0;
            pitjorDorsal = 0;

            tempsMillor = int.MaxValue;
            tempsPitjor = int.MinValue;
            sr = new StreamReader("CURSA.TXT");
            linia = sr.ReadLine();

            while (linia != null)
            {
                dorsal = Convert.ToInt32(linia);
                hhMMss = Convert.ToInt32(sr.ReadLine());

                h = hhMMss / 10000;
                m = hhMMss / 100 % 100;
                s = hhMMss % 100;
                segons = PassarASegons(h, m, s);

                Console.WriteLine($"Dorsal {dorsal}:\t{segons} segons");

                if (segons < tempsMillor)
                {
                    millorDorsal = dorsal;
                    tempsMillor = segons;
                }

                if (segons > tempsPitjor)
                {
                    pitjorDorsal = dorsal;
                    tempsPitjor = segons;
                }

                linia = sr.ReadLine();
            }

                Console.WriteLine(" ");
                Console.WriteLine($"Dorsal guanyador: {millorDorsal}, amb {tempsMillor} segons\nDorsal últim: {pitjorDorsal}, amb {tempsPitjor} segons");
        }

        /// <summary>
        /// Funció que transforma hores, minuts i segons a segons i ho totalitza.
        /// </summary>
        /// <param name="hores">hores entrades, equivalents a 3600 segons.</param>
        /// <param name="minuts">minuts entrats, equivalents a 60 segons.</param>
        /// <param name="segons">segons entrats</param>
        /// <returns>Total de segons</returns>
        public static int PassarASegons (int hores, int minuts, int segons)
        {
            int totalSegons;
            totalSegons = hores * 3600 + minuts * 60 + segons;
            return totalSegons;
        }
    }
}