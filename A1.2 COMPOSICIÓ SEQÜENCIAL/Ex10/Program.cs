namespace Ex10
{
    internal class Program
    {
        /// <summary>
        /// Programa que converteix una quantitat de peus entrada per l'usuari a polzades i de polzades a metres.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            const double INCH_2_CM = 2.54;
            const double FOOT_2_INCH = 12.00;
            double metre, peu;

            Console.Clear();
            Console.WriteLine("Quants peus?");
            peu = Convert.ToDouble(Console.ReadLine());

            metre = (peu * FOOT_2_INCH * INCH_2_CM) / 100.00;

            Console.Clear();
            Console.WriteLine($"{peu:0.00} peus seran {metre:0.0000} metres.");
        }
    }
}
