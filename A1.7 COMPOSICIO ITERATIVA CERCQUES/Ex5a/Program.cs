namespace Ex5a
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, sumatori, increment;
            bool esPerfecte;

            Console.WriteLine("Entra un número.");
            num = Convert.ToInt32(Console.ReadLine());
            sumatori = 0;
            increment = 1;
            esPerfecte = false;

            while (!esPerfecte && increment <= num / 2)
            {
                if (num % increment == 0)
                    sumatori = sumatori + increment;

                esPerfecte = sumatori == num;

                increment++;
            }

            Console.WriteLine(esPerfecte);
        }
    }
}
