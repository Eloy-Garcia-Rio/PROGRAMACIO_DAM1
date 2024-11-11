namespace Ex9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.WriteLine("Entra un número.");
            num = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= 10;  i++)
            {
                Console.WriteLine($"{num} * {i} = {num * i}");
            }
        }
    }
}
