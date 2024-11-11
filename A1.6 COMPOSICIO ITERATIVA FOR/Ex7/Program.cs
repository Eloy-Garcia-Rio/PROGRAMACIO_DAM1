namespace Ex7
{
    internal class Program
    {
        /// <summary>
        /// Programa que, a partir del valor entrat per l'usuari, fa un sumatori de tots els números enters trobats entre 1 i el valor indicat.
        /// Al final de l'itinerari retorna el resultat del sumatori.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int num, sumatori;

            sumatori = 0;

            Console.WriteLine("Entra un número.");
            num = Convert.ToInt32(Console.ReadLine());

            for (int sum = 1; sum <= num; sum++)
            {
                Console.WriteLine($"{sumatori} + {sum}");
                sumatori = sumatori + sum;
            }

            Console.WriteLine($"Resultat final: {sumatori}");
        }
    }
}
