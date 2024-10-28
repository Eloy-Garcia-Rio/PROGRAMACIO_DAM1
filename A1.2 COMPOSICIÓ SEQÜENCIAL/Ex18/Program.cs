namespace Ex18
{
    internal class Program
    {
        /// <summary>
        /// Programa que genera un número aleatori entre 65 i 90 per transformar-lo en la lletra majúscula corresponent segons ASCII.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int lletraASCII;
            char lletra;
            
            Random rnd = new Random();
            lletraASCII = rnd.Next(65,91);

            lletra = (char)lletraASCII;

            Console.WriteLine(lletra);
        }
    }
}
