namespace Ex8
{
    internal class Program
    {
        /// <summary>
        /// Programa que calcula i retorna l'expressió HH:MM:SS d'una quantitat de segons entrada per l'usuari.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int segonsEntrats;
            string resultat;

            Console.Clear();
            Console.WriteLine("Quants segons?");
            segonsEntrats = Convert.ToInt32(Console.ReadLine());

            resultat = ConversorSegons(segonsEntrats);

            Console.WriteLine($"{segonsEntrats}s equivalen a {resultat}");
        }

        /// <summary>
        /// Funció que converteix segons en hores, minuts i segons i expressa el resultat en string.
        /// </summary>
        /// <param name="secondsIn">Segons entrats per l'usuari.</param>
        /// <returns>HH:MM:SS en format string.</returns>
        public static string ConversorSegons(int secondsIn)
        {
            int hours, mins, secs;
            hours = secondsIn / 3600;
            secs = secondsIn % 3600;
            mins = secs / 60;
            secs = secs % 60;
            return $"{hours:00}:{mins:00}:{secs:00}";
        }

    }
}
