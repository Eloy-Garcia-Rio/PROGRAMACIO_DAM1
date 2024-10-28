namespace Ex16
{
    internal class Program
    {
        /// <summary>
        /// Programa que comprova si un any és de trespàs i/o pertany a algun festival.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int any;
            bool esTrespas, esHuluculu, esBulukulu;

            Console.WriteLine("Entra un any.");
            any = Convert.ToInt32(Console.ReadLine());

            esTrespas = EsAnyTraspas(any);
            esHuluculu = EsAnyFestivalHuluculu(any);
            esBulukulu = EsAnyFestivalBulukulu(any);

            if (esTrespas || esHuluculu || esBulukulu)
            {
                Console.WriteLine($"Any de trespàs: {esTrespas}\nAny del festival Huluculu: {esHuluculu}\nAny del festival Bulukulu: {esBulukulu}");
            }
            else
            {
                Console.WriteLine("Aquest és un any normal.");
            }
        }

        /// <summary>
        /// Funcººió que comprova si un any és de trespàs.
        /// </summary>
        /// <param name="any">Any entrat per l'usuari.</param>
        /// <returns>Booleana que indica si és de trespàs o no.</returns>
        public static bool EsAnyTraspas(int any)
        {
            bool esAnyTraspas;
            esAnyTraspas = (any % 4 == 0 && any % 100 != 0) || (any % 400 == 0);
            return esAnyTraspas;
        }

        /// <summary>
        /// Funció que comprova si un any és del festival Huluculu.
        /// </summary>
        /// <param name="any">Any entrat per l'usuari.</param>
        /// <returns>Booleana que indica si és del festival Huluculu o no.</returns>
        public static bool EsAnyFestivalHuluculu(int any)
        {
            bool esFestivalHuluculu;
            esFestivalHuluculu = any % 15 == 0;
            return esFestivalHuluculu;
        }

        /// <summary>
        /// Funció que comprova si un any és del festival Bulukulu.
        /// </summary>
        /// <param name="any">Any entrat per l'usuari.</param>
        /// <returns>Booleana que indica si és del festival Bulukulu o no.</returns>
        public static bool EsAnyFestivalBulukulu(int any)
        {
            bool esFestivalBulukulu;
            esFestivalBulukulu = (any % 55 == 0) && EsAnyTraspas(any);
            return esFestivalBulukulu;
        }
    }
}
