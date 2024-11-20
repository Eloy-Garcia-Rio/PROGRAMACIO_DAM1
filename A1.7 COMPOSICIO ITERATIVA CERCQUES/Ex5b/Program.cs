namespace Ex5b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            bool esPerfecte;

            Console.WriteLine("Entra un número.");
            num = Convert.ToInt32(Console.ReadLine());

            esPerfecte = EsPerfecte(num);

            Console.WriteLine(esPerfecte);
        }

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
