namespace Ex16
{
    internal class Program
    {
        /// <summary>
        /// Programa que genera una mitja piràmide amb asteriscs d'alçada indicada per l'usuari.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int increment, num;

            Console.WriteLine("Entra un número.");
            num = Convert.ToInt32(Console.ReadLine());
            increment = 0;

            for (int i = 1; i <= num; i++)
            {
                for (int j = 0; j <= increment; j++)
                {
                    Console.Write('*');
                }
                increment ++;
                Console.WriteLine();
            }
        }
    }
}