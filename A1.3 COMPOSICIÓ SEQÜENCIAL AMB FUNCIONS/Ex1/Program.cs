namespace Ex1
{
    internal class Program
    {
        /// <summary>
        /// Programa que calcula i retorna l'equivalent en segons d'una quantitat d'hores, minuts i segons donada per l'usuari.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int hores, minuts, segons;
            int totalSegons;

            Console.Clear();
            Console.WriteLine("Hores?");
            hores = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Minuts?");
            minuts = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Segons?");
            segons = Convert.ToInt32(Console.ReadLine());

            totalSegons = CalculSegons(hores, minuts, segons);

            Console.WriteLine($"El valor entrat correspondrà a {totalSegons}s.");
        }

        /// <summary>
        /// Funció que calcula el total de segons que formen un conjunt d'hores, minuts i segons.
        /// </summary>
        /// <param name="hours">Hores entrades</param>
        /// <param name="minutes">Minuts entrats</param>
        /// <param name="seconds">Segons entrats</param>
        /// <returns>Total de segons</returns>
        public static int CalculSegons(int hours, int minutes, int seconds)
        {
            int totalSeconds;

            totalSeconds = (hours * 3600) + (minutes * 60) + seconds;

            return totalSeconds;
        }

    }
}
