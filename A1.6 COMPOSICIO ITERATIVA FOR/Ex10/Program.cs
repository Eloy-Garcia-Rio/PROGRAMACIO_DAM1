namespace Ex10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 4; i <= 300; i = i + 4)
            {
                int counter = i / 4;
                Console.WriteLine(i);

                if (counter % 20 == 0)
                {
                    Console.ReadKey();
                }
            }
        }
    }
}
