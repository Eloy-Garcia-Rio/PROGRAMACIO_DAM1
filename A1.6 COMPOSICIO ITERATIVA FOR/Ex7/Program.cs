namespace Ex7
{
    internal class Program
    {
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
