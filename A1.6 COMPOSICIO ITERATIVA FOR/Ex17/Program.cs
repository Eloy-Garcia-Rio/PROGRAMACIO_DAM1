namespace Ex17
{
    internal class Program
    {
        /// <summary>
        /// Programa que genera les taules de multiplicar de tots els números trobats entre 0 i 10.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            for (int i = 0;  i <= 10; i++)
            {
                MostrarTaula(i);
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Funció que retorna les diferents línies de les taules de multiplicar.
        /// </summary>
        /// <param name="numTaula"></param>
        public static void MostrarTaula(int numTaula)
        {
            for (int j = 0; j <= 10;  j++)
            {
                Console.WriteLine($"{numTaula} * {j} = {numTaula * j}");
            }
        }
    }
}
