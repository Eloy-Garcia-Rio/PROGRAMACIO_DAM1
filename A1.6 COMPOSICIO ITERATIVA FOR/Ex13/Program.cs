namespace Ex13
{
    internal class Program
    {
        /// <summary>
        /// Programa que, a partir del fitxer "Girona lliga23_24_v2.txt", calcula els partits guanyats, els partits empatats, els partits perduts i el total de punts.
        /// Al final de l'itinerari retorna el total de partits, els partits guanyats, els partits empatats, els partits perduts i el total de punts.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int totalJornades, golsGir, golsRival, totalPunts, counterW, counterD, counterL;
            string linia;
            StreamReader sr;

            golsGir = 0;
            golsRival = 0;
            totalPunts = 0;
            counterW = 0;
            counterD = 0;
            counterL = 0;

            sr = new StreamReader("Girona lliga23_24_v2.txt");
            linia = sr.ReadLine();
            totalJornades = Convert.ToInt32(linia);
            linia = sr.ReadLine();

            for (string i = linia; i != null; i = sr.ReadLine())
            {
                golsGir = Convert.ToInt32(i);
                golsRival = Convert.ToInt32(sr.ReadLine());

                if (golsGir > golsRival)
                {
                    totalPunts = totalPunts + 3;
                    counterW++;
                }
                else if (golsGir == golsRival)
                {
                    totalPunts = totalPunts + 1;
                    counterD++;
                }
                else
                {
                    counterL++;
                }
            }

            Console.WriteLine($"Partits jugats: {totalJornades}\nTotal punts: {totalPunts}\nPartits guanyats: {counterW}\nPartits empatats: {counterD}\nPartits perduts: {counterL}");
        }
    }
}
