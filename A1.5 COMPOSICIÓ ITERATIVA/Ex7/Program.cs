namespace Ex7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int FI = 0;
            int num, max, min, contador;

            max = 0;
            min = 0;
            contador = 0;
            num = Convert.ToInt32(Console.ReadLine());

            while (num != FI)
            {
                contador = contador + 1;
                if (max == 0 && min == 0)
                {
                    max = num;
                    min = num;
                    num = Convert.ToInt32(Console.ReadLine());
                }
                else if (max <= num)
                {
                    max = num;
                    num = Convert.ToInt32(Console.ReadLine());
                }
                else if (min >= num)
                {
                    min = num;
                    num = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    num = Convert.ToInt32(Console.ReadLine());
                }


            }
            Console.WriteLine($"Número més gran: {max}\nNúmero més petit: {min}");
        }
    }
}
