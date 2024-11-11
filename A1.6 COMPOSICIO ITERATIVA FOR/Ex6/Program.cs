namespace Ex6
{
    internal class Program
    {
        /// <summary>
        /// Programa que demana a l'usuari que entri 10 valors enters diferents i els classifica segons si són positius o negatius.
        /// Al final de l'itinerari retorna la quantitat de valors positius i de valors negatius.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int num, nPos, nNeg;

            nPos = 0;
            nNeg = 0;

            for (int counter = 1; counter <= 10; counter++)
            {
                Console.WriteLine("Entra un número.");
                num = Convert.ToInt32(Console.ReadLine());

                if (num % 2 == 0)
                {
                    nPos++;
                }
                else
                {
                    nNeg++;
                }
            }

            Console.WriteLine($"Números positius: {nPos}\nNúmeros negatius: {nNeg}");
        }
    }
}
