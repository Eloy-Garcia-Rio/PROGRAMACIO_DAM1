namespace Ex6b
{
    internal class Program
    {
        /// <summary>
        /// Programa que retorna si un número entrat és primer.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int num;
            bool esPrimer;

            Console.WriteLine("Entra un número.");
            num = Convert.ToInt32(Console.ReadLine());

            esPrimer = EsPrimer(num);

            Console.WriteLine(esPrimer);
        }

        /// <summary>
        /// Funció que comprova si el número passat és primer.
        /// </summary>
        /// <param name="n">Número passat.</param>
        /// <returns>Booleana indicant si és primer.</returns>
        public static bool EsPrimer(int n)
        {
            int sum, inc;
            bool isPrime;
            sum = 0;
            inc = 1;
            isPrime = false;

            while (!isPrime && inc <= n)
            {
                if (n % inc == 0)
                    sum = sum + inc;

                if (n == 1)
                    isPrime = true;
                else
                {
                    isPrime = sum == n + 1;
                }

                inc++;
            }

            return isPrime;
        }
    }
}
