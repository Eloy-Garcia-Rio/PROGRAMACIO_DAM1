namespace Ex15
{
    internal class Program
    {
        /// <summary>
        /// Programa que, mentres la línia llegida del fitxer no sigui -1, calcula els resultats dels partits per determinar els punts obtinguts, assignant els valors de les línies senars
        /// al Girona i les línies parelles a l'equip contrari.
        /// Al final de l'itinerari, el programa retorna el total de punts obtinguts durant la lliga i la quantitat de partits guanyats, empatats i perduts.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int totalPunts, golsGir, golsRival;
            int partitsGuanyats, partitsPerduts, partitsEmpatats;
            StreamReader sr;

            totalPunts = 0;
            golsGir = 0;
            golsRival = 0;
            partitsEmpatats = 0;
            partitsGuanyats = 0;
            partitsPerduts = 0;

            sr = new StreamReader("Girona lliga23_24.txt");
            golsGir = Convert.ToInt32(sr.ReadLine());
            golsRival = Convert.ToInt32(sr.ReadLine());

            while (golsGir != -1)
            {

                if (golsGir > golsRival)
                {
                    totalPunts = totalPunts + 3;
                    partitsGuanyats++;
                }
                else if (golsGir == golsRival)
                {
                    totalPunts = totalPunts + 1;
                    partitsEmpatats++;
                }
                else
                {
                    partitsPerduts++;
                }

                golsGir = Convert.ToInt32(sr.ReadLine());
                golsRival = Convert.ToInt32(sr.ReadLine());
            }

            sr.Close();

            if (totalPunts == 0 && partitsGuanyats == 0 && partitsPerduts == 0 && partitsEmpatats == 0)
            {
                Console.WriteLine("El fitxer és buit.");
            }
            else
            {
                Console.WriteLine($"Total de punts: {totalPunts}\nPartits guanyats: {partitsGuanyats}\nPartits empatats: {partitsEmpatats}\nPartits perduts: {partitsPerduts}");
            }
    
        }
    }
}
