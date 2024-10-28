namespace Ex2
{
    internal class Program
    {
        /// <summary>
        /// Un programa que, a partir del valor d'edat entrat, suma 1 al valor per calcular l'edat passat un any.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int edat;

            Console.Clear();
            Console.WriteLine("Quina és la teva edat actual?");
            edat = Convert.ToInt32(Console.ReadLine());

            edat = edat + 1;

            Console.Clear();
            Console.WriteLine($"L'any vinent tindràs {edat} anys.");
        }
    }
}
