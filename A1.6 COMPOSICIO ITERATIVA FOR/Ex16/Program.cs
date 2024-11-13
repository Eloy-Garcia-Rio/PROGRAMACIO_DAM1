namespace Ex16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int increment, num;

            Console.WriteLine("Entra un número.");
            num = Convert.ToInt32(Console.ReadLine());
            increment = 0;

            for (int p = 1; p <= num; p++)
            {
                for (int i = 0; i <= increment; i++)
                {
                    Console.Write('*');
                }
                increment ++;
                Console.WriteLine();
            }
        }
    }
}