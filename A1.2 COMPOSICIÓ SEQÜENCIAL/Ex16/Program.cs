namespace Ex16
{
    internal class Program
    {
        /// <summary>
        /// Programa que genera dos valors aleatoris trobats entre 0 i 6 per determinar el resultat d'un partit de futbol.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int golsPSG;
            int golsGFC;

            Console.Clear();
           
            Random rnd = new Random();
            golsPSG = rnd.Next(0, 7);
            golsGFC = rnd.Next(0, 7);

            Console.WriteLine($"PSG {golsPSG} - {golsGFC} GFC");
        }
    }
}
