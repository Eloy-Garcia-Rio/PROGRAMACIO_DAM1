namespace Ex7
{
    internal class Program
    {
        /// <summary>
        /// Programa que suma els dígits que formen un número de 4 dígits entrat per l'usuari i retorna el valor corresponent.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int numUsuari;
            int numSumatori;

            Console.Clear();
            Console.WriteLine("Entra un número de 4 dígits.");
            numUsuari = Convert.ToInt32(Console.ReadLine());

            numSumatori = SumatoriDigits(numUsuari);

            Console.WriteLine($"Els dígits {numUsuari} sumen {numSumatori}");
        }

        /// <summary>
        /// Funció que segmenta un número de 4 dígits i els suma.
        /// </summary>
        /// <param name="numberIn">Número de 4 dígits entrat per l'usuari.</param>
        /// <returns>Sumatori dels seus dígits.</returns>
        public static int SumatoriDigits(int numberIn)
        {
            int digitK, digitC, digitX, digitI;
            int sum;

            digitI = numberIn % 10;
            digitX = (numberIn / 10) % 10;
            digitC = (numberIn / 100) % 10;
            digitK = numberIn / 1000;
            sum = digitK + digitC + digitX + digitI;

            return sum;
        }

    }
}
