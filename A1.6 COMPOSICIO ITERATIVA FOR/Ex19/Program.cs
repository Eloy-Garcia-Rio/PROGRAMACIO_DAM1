namespace Ex19
{
    internal class Program
    {
        /// <summary>
        /// Programa que genera una seqüència de sumatoris que finalitza amb el número indicat per l'usuari.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int num, counter;

            Console.WriteLine("Entra un número.");
            num = Convert.ToInt32(Console.ReadLine());
            counter = 0;

            for (int i = 1; i <= num; i++)
            {
                counter += i;

                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);

                    if (j < i)
                        Console.Write(" + ");
                }

                Console.WriteLine($" = {counter}");
            }
        }
    }
}
