namespace Ex18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.WriteLine("Entra un número.");
            num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j < num - i + 1; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write(k);
                    Console.Write(" ");
                }
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}
