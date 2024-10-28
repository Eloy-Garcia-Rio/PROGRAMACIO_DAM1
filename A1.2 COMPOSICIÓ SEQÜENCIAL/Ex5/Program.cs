namespace Ex5
{
    internal class Program
    {
        /// <summary>
        /// Programa que llegeix un caràcter entrat per l'usuari i retorna el seu valor ASCII.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            char lletraEntrada;
            int lletraASCII;

            Console.Clear();
            Console.WriteLine("Quina lletra vols convertir?");
            lletraEntrada = Convert.ToChar(Console.Read());

            lletraASCII = (int)lletraEntrada;

            Console.Clear();
            Console.WriteLine($"El valor ASCII de {lletraEntrada} és {lletraASCII}.");
            
            
        }
    }
}
