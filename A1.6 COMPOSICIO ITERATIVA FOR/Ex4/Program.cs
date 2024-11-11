namespace Ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;

            Console.WriteLine("Primer valor?");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Segon valor?");
            num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 < num2)
            {
                for (int i = num1; i <= num2; i++)
                {
                    if (i % 7 == 0)
                    {
                        Console.WriteLine(" ");
                    }
                    else
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            else if (num2 < num1)
            {
                for (int i = num2; i <= num1; i++)
                {
                    if (i % 7 == 0)
                    {
                        Console.WriteLine(" ");
                    }
                    else
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            else
            {
                Console.WriteLine("Els valors entrats són idèntics.");
            }
        }
    }
}
