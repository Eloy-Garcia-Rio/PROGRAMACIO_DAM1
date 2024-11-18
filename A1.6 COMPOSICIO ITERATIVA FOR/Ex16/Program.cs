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
            int num;

            Console.WriteLine("Entra un número.");
            num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write('*');
                }

                Console.WriteLine();
            }
        }
    }
}