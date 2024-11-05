namespace Ex9
{
    internal class Program
    {
        /// <summary>
        /// Programa que, mentres el resultat de la divisió no sigui 0, divideix un valor entrat per l'usuari per calcular la quantitat de dígits que té.
        /// A l'acabar l'itinerari retorna quantitat de dígits.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int num, nDigits;

            nDigits = 0;

            num = Convert.ToInt32(Console.ReadLine());

            while (num != 0)
            {
                num = num / 10;
                nDigits++;
            }

            Console.WriteLine(nDigits);
        }
    }
}
