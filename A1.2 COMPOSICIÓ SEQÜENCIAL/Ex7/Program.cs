namespace Ex7
{
    internal class Program
    {
        /// <summary>
        /// Programa que, a partir dels valors de divisor i dividend introduïts per l'usuari, calcula el cocient i residu enters.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int divisor, dividend;
            int cocient, residu;

            Console.Clear();
            Console.WriteLine("Valor del divisor?");
            divisor = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Valor del dividend?");
            dividend = Convert.ToInt32(Console.ReadLine());

            cocient = divisor / dividend;
            residu = divisor % dividend;

            Console.Clear();
            Console.WriteLine($"El cocient de la divisió {divisor} / {dividend} és {cocient}.");
            Console.WriteLine($"El residu de la divisió {divisor} / {dividend} és {residu}.");
        }
    }
}
