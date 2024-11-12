namespace Ex18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int kCond = 4;
            int inc = 0;
            for (int p = 0; p <= 4; p++)
            {
                for (int k = 0; k <= kCond; k++)
                {
                    Console.Write(" ");
                }
                kCond--;
                for (int i = 0; i <= inc; i++)
                {
                    Console.Write(i+1);
                }
                inc += 2;
                Console.WriteLine();
            }
        }
    }
}
