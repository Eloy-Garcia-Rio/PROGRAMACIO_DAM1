namespace Ex12
{
    internal class Program
    {
        /// <summary>
        /// Programa que comprova i retorna si l'any entrat és de trespàs o no.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int any;
            bool esTrespas;

            Console.WriteLine("Entra un any.");
            any = Convert.ToInt32(Console.ReadLine());

            esTrespas = EsTrespas(any);

            Console.WriteLine(esTrespas);
        }

        /// <summary>
        /// Funció que comprova si l'any entrat és de trespàs o no.
        /// </summary>
        /// <param name="any">Any entrat per l'usuari.</param>
        /// <returns>Booleana que indica si l'any és de trespàs o no.</returns>
        public static bool EsTrespas(int any)
        {
            bool esTrespas;
            esTrespas = (any % 4 == 0 && any % 100 != 0) || (any % 400 == 0);
            return esTrespas;
        }
    }
}
