namespace Ex5b
{
    internal class Program
    {
        /// <summary>
        /// Programa que retorna si un número entrat és perfecte.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int num;
            bool esPerfecte;

            Console.WriteLine("Entra un número.");
            num = Convert.ToInt32(Console.ReadLine());

            esPerfecte = EsPerfecte(num);

            Console.WriteLine(esPerfecte);
        }

        /// <summary>
        /// Funció que comprova si el número entrat és perfecte.
        /// </summary>
        /// <param name="n">Número entrat.</param>
        /// <returns>Booleana indicant si és perfecte.</returns>
        public static bool EsPerfecte(int n)
        {
            int sum, inc;
            bool isPerf;
            sum = 0;
            inc = 1;
            isPerf = false;

            while (!isPerf && inc <= n / 2)
            {
                if (n % inc == 0)
                    sum = sum + inc;

                isPerf = sum == n;
                inc++;
            }

            return isPerf;
        }
    }
}
