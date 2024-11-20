namespace Ex6a
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, sumatori, increment;
            bool esPrimer;

            Console.WriteLine("Entra un número.");
            num = Convert.ToInt32(Console.ReadLine());
            sumatori = 0;
            increment = 1;
            esPrimer = false;

            while (!esPrimer && increment <= num)
            {
                if (num % increment == 0)
                    sumatori = sumatori + increment;

                if (num == 1)
                    esPrimer = true;
                else
                {
                    esPrimer = sumatori == num + 1;
                }

                increment++;
            }

            Console.WriteLine(esPrimer);
        }
    }
}
