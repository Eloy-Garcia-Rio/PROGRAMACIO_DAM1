namespace Ex16b
{
    internal class Program
    {
        /// <summary>
        /// Programa que genera una mitja piràmide amb asteriscs d'alçada indicada per l'usuari.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int num;

            Console.WriteLine("Entra un número.");
            num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine(GenerarLinia('*', i));
            }
        }

        /// <summary>
        /// Funció que genera les línies de text que formen la piràmide.
        /// </summary>
        /// <param name="car">Caràcter a utilitzar.</param>
        /// <param name="longitud">Longitud de la línia actual.</param>
        /// <returns>Cadena de caràcters per a la línia actual.</returns>
        public static string GenerarLinia(char car, int longitud)
        {
            string linia;
            linia = "";

            for (int j = 1; j <= longitud; j++)
            {
                linia = linia + car;
            }

            return linia;
        }
    }
}
