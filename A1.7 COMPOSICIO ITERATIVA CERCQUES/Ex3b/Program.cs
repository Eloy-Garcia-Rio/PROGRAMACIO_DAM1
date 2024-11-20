namespace Ex3b
{
    internal class Program
    {
        /// <summary>
        /// Porgrama que llegeix enters entrats per l'usuari, comprova si algun dels valors és parell i retorna el resultat.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int num;
            bool esParell;

            esParell = false;
            Console.WriteLine("Entra un número.");
            num = Convert.ToInt32(Console.ReadLine());

            while (!esParell && num != -9999)
            {
                esParell = 1.00 * num % 2 == 0.00;

                num = Convert.ToInt32(Console.ReadLine());
            }

            if (esParell)
                Console.WriteLine("Hi ha valors parells.");
            else
                Console.WriteLine("No hi ha valors parells.");
        }
    }
}
