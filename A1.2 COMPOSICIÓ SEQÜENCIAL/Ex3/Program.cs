namespace Ex3
{
    internal class Program
    {
        /// <summary>
        /// Programa que sol·licita hores, minuts i segons per tal de convertir tots els valors a segons.
        /// Els minuts els multiplica per 60, ja que 1 minut són 60 segons.
        /// Les hores les multiplica per 3600, ja que 1 hora són 60 minuts.
        /// Finalment suma tots els valors per donar el resultat total.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int hores;
            int minuts;
            int segons;

            Console.Clear();
            Console.WriteLine("Hores?");
            hores = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Minuts?");
            minuts = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Segons?");
            segons = Convert.ToInt32(Console.ReadLine());

            hores = hores * 3600;
            minuts = minuts * 60;
            segons = hores + minuts + segons;

            Console.Clear();
            Console.WriteLine($"Aquest temps equival a {segons} segons.");
        }
    }
}
