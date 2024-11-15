namespace Ex15b
{
    internal class Program
    {
        /// <summary>
        /// Programa que genera un quadrat amb asteriscs d'alçada indicada per l'usuari.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int num;

            Console.WriteLine("Entra un número.");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Entra un caràcter");


            for (int i = 0; i < num; i++)
            {
                Console.WriteLine(GenerarLinia('*', num));
            }
        }

        /// <summary>
        /// Funcio que genera línies d'asteriscs de la llargada indicada per l'usuari.
        /// </summary>
        /// <param name="car">Caràcter a utilitzar.</param>
        /// <param name="longitud">Longitud de la cadena, determinada per l'usuari.</param>
        /// <returns>Cadena de caràcters.</returns>
        public static string GenerarLinia (char car, int longitud)
        {
            string linia;
            linia = "";
            for (int i = 1; i <= longitud; i++)
            {
                linia = linia + car;
            }

            return linia;
        }
    }
}
