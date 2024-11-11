namespace Ex8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, resultat;

            Console.WriteLine("Entra un número.");
            num = Convert.ToInt32(Console.ReadLine());

            resultat = num;

            for (int mult = 1; mult < num; mult++)
            {
                int factorial;
                factorial = num - mult;
                Console.WriteLine($"{resultat} * {factorial} = {resultat * factorial}");
                resultat = resultat * factorial;
            }

        }
    }
}
