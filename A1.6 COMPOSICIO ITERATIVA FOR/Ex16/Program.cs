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

            for (int i = 1; i <= num; i++)
            {
                for (int j = 0; j <= increment; j++)
                {
                    Console.Write('*');
                }
                increment ++;
                Console.WriteLine();
            }
        }
    }
}