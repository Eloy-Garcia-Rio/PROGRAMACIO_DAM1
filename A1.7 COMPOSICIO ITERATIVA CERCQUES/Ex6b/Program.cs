namespace Ex6b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            bool esPrimer;

            Console.WriteLine("Entra un número.");
            num = Convert.ToInt32(Console.ReadLine());

            esPrimer = EsPrimer(num);

            Console.WriteLine(esPrimer);
        }

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
