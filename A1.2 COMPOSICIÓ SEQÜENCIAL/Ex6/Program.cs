namespace Ex6
{
    internal class Program
    {
        /// <summary>
        /// Programa que transforma la lletra minúscula entrada per l'usuari al seu equivalent en majúscula mitjançant transformacions del valor ASCII.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            char lletraMinus;
            char lletraMajus;
            bool resposta;

            Console.Clear();
            Console.WriteLine("Quina lletra vols transformar?");
            lletraMinus = Convert.ToChar(Console.Read());

            lletraMajus = (char)((int)lletraMinus - 32);

            Console.Clear();
            Console.WriteLine($"La lletra {lletraMinus} en majúscula serà {lletraMajus}");
        }
    }
}
