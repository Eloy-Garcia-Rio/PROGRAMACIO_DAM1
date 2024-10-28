namespace Ex9
{
    internal class Program
    {
        /// <summary>
        /// Programa que converteix una quantitat de polzades entrada per l'usuari a metres.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            const double INCH_2_CM = 2.54;
            double metre, polzada;

            Console.Clear();
            Console.WriteLine("Quantes polzades?");
            polzada = Convert.ToDouble(Console.ReadLine());

            metre = (polzada * INCH_2_CM) / 100.00;

            Console.Clear();
            Console.WriteLine($"{polzada:0.00} polzades seran {metre:0.0000} metres.");
        }
    }
}
