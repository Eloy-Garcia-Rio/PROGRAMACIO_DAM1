namespace Ex4
{
    internal class Program
    {
        /// <summary>
        /// Programa que, a partir dels valors "a" i "b" entrats per l'usuari, calcula el valor de l'incògnita "x" per tal de resoldre l'igualtat ax + b = 0.
        /// Per tal de fer això, el programa realitza el càlcul x = - (b / a).
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            double valorA;
            double valorB;
            double valorX;

            Console.Clear();
            Console.WriteLine("Primer valor?");
            valorA = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Segon valor?");
            valorB = Convert.ToDouble(Console.ReadLine());

            if (valorA != 0)
            {
                valorX = valorB / valorA * -1.00;
                Console.Clear();
                Console.WriteLine($"Per l'equació {valorA:0.00}X + {valorB:0.00} = 0, el valor de X serà {valorX:0.00}.");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("No es pot calcular el valor de X.");
            }


        }
    }
}
