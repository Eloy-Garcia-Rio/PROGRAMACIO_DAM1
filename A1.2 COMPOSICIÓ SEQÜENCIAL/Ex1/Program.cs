namespace Ex1
{
    internal class Program
    {
        /// <summary>
        /// A partir del valor entrat per consola, el programa calcula quin es el valor següent.
        /// Aquest procés causa que la variable n es transformi, la qual cosa ens requerirà de fer n-1 per poder indicar el valor original.
        /// Amb el modificador :0000 transformem la vista dels enters a 4 dígits.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            n = n + 1;

            Console.WriteLine($"HAS ENTRAT : {n - 1} I UN MÉS VAL {n}");
            Console.WriteLine($"HAS ENTRAT : {n - 1:0000} I UN MÉS VAL {n:0000}");
        }
    }
}
