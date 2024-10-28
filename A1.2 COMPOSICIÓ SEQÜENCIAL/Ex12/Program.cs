namespace Ex12
{
    internal class Program
    {
        /// <summary>
        /// Programa que, a partir dels valors a i b entrats per l'usuari, crea un mirall de l'ordre d'entrada d'aquests 
        /// mitjançant un valor c que actua de pivot.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int a, b, c;

            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());

            c = a;
            a = b;
            b = c;

            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
