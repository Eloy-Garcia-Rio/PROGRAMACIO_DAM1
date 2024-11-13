namespace Ex8
{
    internal class Program
    {
        /// <summary>
        /// Programa que calcula el factorial d'un valor entrat per l'usuari.
        /// Al final de l'itinerari retorna el resultat del factorial.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int num, resultat;

            Console.WriteLine("Entra un número.");
            num = Convert.ToInt32(Console.ReadLine());

            resultat = num;

            for (int i = 1; i < num; i++)
            {
                int factorial;
                factorial = num - i;
                Console.WriteLine($"{resultat} * {factorial} = {resultat * factorial}");
                resultat = resultat * factorial;
            }

            Console.WriteLine($"Resultat final: {resultat}");
        }
    }
}
