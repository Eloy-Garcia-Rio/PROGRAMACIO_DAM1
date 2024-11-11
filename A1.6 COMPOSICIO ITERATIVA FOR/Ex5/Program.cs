namespace Ex5
{
    internal class Program
    {
        /// <summary>
        /// Programa que demana a l'usuari que entri 10 valors enters diferents i fa un sumatori amb ells.
        /// Al final de l'itinerari retorna el resultat del sumatori.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int num, sum;

            sum = 0;

            for (int counter = 1; counter <= 10; counter++)
            {
                Console.WriteLine("Entra un número.");
                num = Convert.ToInt32(Console.ReadLine());
                sum = sum + num;
            }

            Console.WriteLine(sum);
        }
    }
}
