namespace Ex5
{
    internal class Program
    {
        /// <summary>
        /// Programa que converteix un valor de polzades entrat per l'usuari a metres i retorna el resultat.
        /// </summary>
        /// <param name="args"></param>

        const double INCH_2_CM = 2.54;

        static void Main(string[] args)
        {
            double polzades, metres;

            Console.Clear();
            Console.WriteLine("Quantes polzades?");
            polzades = Convert.ToDouble(Console.ReadLine());

            metres = Inch2Metre(polzades);

            Console.WriteLine($"{polzades:0.00} polzades seran {metres:0.00} metres.");

        }

        /// <summary>
        /// Funció que converteix de polzades a metres.
        /// </summary>
        /// <param name="inch">Polzades</param>
        /// <returns>Metres</returns>
        public static double Inch2Metre(double inch)
        {
            double metre;
            metre = (inch * INCH_2_CM) / 100;
            return metre;
        }

    }
}
