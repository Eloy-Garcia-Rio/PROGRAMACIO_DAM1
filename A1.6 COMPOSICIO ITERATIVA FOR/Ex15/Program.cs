namespace Ex15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            char asciiArt;

            Console.WriteLine("Entra un número.");
            num = Convert.ToInt32(Console.ReadLine());
            asciiArt = '*';

            for (int i = 0; i < num * num; i++)
            {
                
                if (i % num == 0 && i != 0)
                {
                    Console.WriteLine(" ");
                }

                Console.Write(asciiArt);
            }
        }
    }
}
