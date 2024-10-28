namespace Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 3;
            int c = -10;
            bool isTrue;

            isTrue = a > 3;
            Console.WriteLine($"{isTrue}");
            isTrue = a > c;
            Console.WriteLine($"{isTrue}");
            isTrue = b != c;
            Console.WriteLine($"{isTrue}");
            isTrue = a == 3;
            Console.WriteLine($"{isTrue}");
            isTrue = a * b == 15;
            Console.WriteLine($"{isTrue}");
            isTrue = c / b < a;
            Console.WriteLine($"{isTrue}");
            isTrue = c / b == -10;
            Console.WriteLine($"{isTrue}");
            isTrue = a + b + c == 5;
            Console.WriteLine($"{isTrue}");
            isTrue = (a + b == 8) && (a - b == 2);
            Console.WriteLine($"{isTrue}");
            isTrue = (a + b == 8) || (a - b == 6);
            Console.WriteLine($"{isTrue}");
            isTrue = a > 3 && b > 3 && c < 3;
            Console.WriteLine($"{isTrue}");
        }
    }
}
