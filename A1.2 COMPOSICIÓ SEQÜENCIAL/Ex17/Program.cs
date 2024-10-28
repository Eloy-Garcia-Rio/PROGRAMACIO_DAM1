namespace Ex17
{
    internal class Program
    {
        /// <summary>
        /// Programa que genera un número aleatori trobat entre 1 i el número determinat per l'usuari com si fos una tirada de daus.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int caresDau;
            int resultatDau;

            Console.Clear();
            Console.WriteLine("Quantes cares té el dau?");
            caresDau = Convert.ToInt32(Console.ReadLine());

            Random rnd = new Random();
            resultatDau = rnd.Next(1, caresDau+1);

            Console.Clear();
            Console.WriteLine(resultatDau);
        }
    }
}
