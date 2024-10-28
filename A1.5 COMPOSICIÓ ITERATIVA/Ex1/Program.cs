namespace Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int FI = 0;
            int num, contador;

            contador = 0;
            num = Convert.ToInt32(Console.ReadLine());

            while (num != FI)
            {
                contador = contador + 1;
                Console.WriteLine($"Iteració {contador} --> {num}");
                num = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine($"TOTAL MISSATGES: {contador}");
        }
    }
}
