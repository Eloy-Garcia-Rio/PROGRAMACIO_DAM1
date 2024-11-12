namespace Ex17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0;  i <= 10; i++)
            {
                MostrarTaula(i);
                Console.WriteLine();
            }
        }

        public static void MostrarTaula(int numTaula)
        {
            for (int j = 0; j <= 10;  j++)
            {
                Console.WriteLine($"{numTaula} * {j} = {numTaula * j}");
            }
        }
    }
}
