namespace Ex2b
{
    internal class Program
    {
        /// <summary>
        /// Porgrama que llegeix enters entrats per l'usuari, comprova si el primer valor entrat per l'usuari es repeteix i retorna el resultat.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int primerNum, num;
            bool esRepeteix;

            esRepeteix = false;
            Console.WriteLine("Entra un número.");
            primerNum = Convert.ToInt32(Console.ReadLine());
            num = 0;

            while (!esRepeteix && num != -9999)
            {
                esRepeteix = num == primerNum;

                num = Convert.ToInt32(Console.ReadLine());
            }

            if (esRepeteix)
                Console.WriteLine("El primer número es repeteix.");
            else
                Console.WriteLine("El primer número no es repeteix.");
        }
    }
}
