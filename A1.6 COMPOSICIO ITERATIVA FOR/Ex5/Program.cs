namespace Ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, sum;

            sum = 0;

            for (int counter = 1; counter <= 10; counter++)
            {
                Console.WriteLine("Entra un número.");
                num = Convert.ToInt32(Console.ReadLine());
                sum = sum + num;
            }
            Console.WriteLine(sum);
        }
    }
}
