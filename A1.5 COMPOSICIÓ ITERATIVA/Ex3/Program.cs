namespace Ex3
{
    internal class Program
    {
        /// <summary>
        /// Programa que, mentres el valor entrat per l'usuari no sigui 0, porta un recompte dels valors positius i negatius entrats.
        /// A l'acabar l'itinerari retorna la quantitat de valors positius i negatius entrats.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            const int FI = 0;
            int num, contadorPos, contadorNeg;

            contadorPos = 0;
            contadorNeg = 0;
            num = Convert.ToInt32(Console.ReadLine());

            while(num != FI)
            {
                if (num > 0)
                {
                    contadorPos = contadorPos + 1;
                    num = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    contadorNeg = contadorNeg + 1;
                    num = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine($"TOTAL POSITIUS: {contadorPos}\nTOTAL NEGATIUS: {contadorNeg}");
        }
    }
}
