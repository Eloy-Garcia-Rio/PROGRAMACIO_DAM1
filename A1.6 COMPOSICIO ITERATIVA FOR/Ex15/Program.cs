namespace Ex15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.WriteLine("Entra un número.");
            num = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < num * num; i++)
            {
                
                if (i % num == 0 && i != 0)
                {
                    Console.WriteLine(" ");
                }

                Console.Write('*');
            }
        }
    }
}
