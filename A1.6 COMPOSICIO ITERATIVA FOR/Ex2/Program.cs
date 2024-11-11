namespace Ex2
{
    internal class Program
    {
        /// <summary>
        /// Programa que retorna tots els números parells enters trobats entre 2 i 40, ambdòs inclosos.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            for (int num = 2; num <= 40; num = num + 2)
                Console.WriteLine(num);
        }
    }
}
