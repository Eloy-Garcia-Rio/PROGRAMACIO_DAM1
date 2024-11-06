namespace Ex15
{
    internal class Program
    {
        /// <summary>
        /// Programa que, mentres la línia llegida del fitxer no sigui -1, calcula els resultats dels partits per determinar els punts obtinguts, assignant els valors de les línies senars
        /// al Girona i les línies parelles a l'equip contrari.
        /// Al final de l'itinerari, el programa retorna el total de punts obtinguts durant la lliga.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int totalPunts, golsGir, golsRival;
            string liniaGir, liniaRival;
            bool esBuit;
            StreamReader sr;

            totalPunts = 0;
            golsGir = 0;
            golsRival = 0;

            sr = new StreamReader("Girona lliga23_24.txt");
            liniaGir = sr.ReadLine();
            liniaRival = sr.ReadLine();
            esBuit = liniaGir == null;

            while (liniaGir != "-1")
            {
                golsGir = Convert.ToInt32(liniaGir);
                golsRival = Convert.ToInt32(liniaRival);

                if (golsGir > golsRival)
                {
                    totalPunts = totalPunts + 3;
                    liniaGir = sr.ReadLine();
                    liniaRival = sr.ReadLine();
                }
                else if (golsGir == golsRival)
                {
                    totalPunts = totalPunts + 1;
                    liniaGir = sr.ReadLine();
                    liniaRival = sr.ReadLine();
                }
                else
                {
                    liniaGir = sr.ReadLine();
                    liniaRival = sr.ReadLine();
                }
            }

            sr.Close();

            if (esBuit)
            {
                Console.WriteLine("El fitxer és buit");
            }
            else
            {
                Console.WriteLine($"Total de punts: {totalPunts}");
            }
        
        }
    }
}
