namespace Ex3
{
    internal class Program
    {
        /// <summary>
        /// Programa que retorna la forma majúscula d'una lletra minúscula entrada per l'usuari.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            char lletraMinus, lletraMajus;

            Console.Clear();
            Console.WriteLine("Entra una lletra minúscula.");
            lletraMinus = Convert.ToChar(Console.Read());

            lletraMajus = Minus2Majus(lletraMinus);

            Console.WriteLine($"La màjuscula d'aquesta lletra és {lletraMajus}");
        }

        /// <summary>
        /// Funció que calcula el valor ASCII de la versió majúscula de la lletra minúscula entrada.
        /// </summary>
        /// <param name="lowerCase">Minúscula entrada</param>
        /// <returns>Equivalent en majúscula.</returns>
        public static char Minus2Majus(char lowerCase)
        {
            int upperCase;
            upperCase = (int)lowerCase - 32;
            return (char)upperCase;
        }

    }
}
