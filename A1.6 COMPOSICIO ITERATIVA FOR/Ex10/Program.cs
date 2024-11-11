namespace Ex10
{
    internal class Program
    {
        /// <summary>
        /// Programa que mostra tots els enters múltiples de 4 trobats entre 0 i 300, ambdòs inclosos.
        /// Cada 20 valors mostrats, el sistema espera input per part de l'usuari abans de continuar.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            for (int i = 4; i <= 300; i = i + 4)
            {
                int counter = i / 4;
                Console.WriteLine(i);

                if (counter % 20 == 0)
                {
                    Console.ReadKey();
                }
            }
        }
    }
}
