namespace Ex14
{
    internal class Program
    {
        /// <summary>
        /// Programa que transforma qualsevol quantitat de segons en un conjut d'hores, minuts i segons.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int segonsUsuari;
            int segons, minuts, hores;

            Console.Clear();
            Console.WriteLine("Quants segons?");
            segonsUsuari = Convert.ToInt32(Console.ReadLine());

            minuts = segonsUsuari / 60;
            hores = minuts / 60;
            minuts = minuts % 60;
            segons = segonsUsuari % 60;

            Console.Clear();
            Console.WriteLine($"{segonsUsuari} equivalen a {hores:00}:{minuts:00}:{segons:00}.");
        }
    }
}
