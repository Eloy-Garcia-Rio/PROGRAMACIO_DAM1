namespace Ex1
{
    internal class Program
    {
        /// <summary>
        /// Programa que, mentres el valor entrat per l'usuari no sigui 0, porta un recompte la quantitat de valors entrats.
        /// A l'acabar l'itinerari retorna la quantitat de valors entrats.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            const int FI = 0;
            int num, contador;

            contador = 0;
            num = Convert.ToInt32(Console.ReadLine());

            while (num != FI)
            {
                contador = contador + 1;
                Console.WriteLine($"Iteració {contador} --> {num}");
                num = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine($"TOTAL MISSATGES: {contador}");
        }
    }
}
