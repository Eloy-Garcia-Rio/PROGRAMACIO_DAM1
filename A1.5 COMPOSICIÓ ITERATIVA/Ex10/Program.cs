namespace Ex10
{
    internal class Program
    {
        /// <summary>
        /// Programa que, mentres les tirades de 1 i de 6 siguin diferents, farà una tirada de daus i la classificarà segons el resultat.
        /// A l'acabar l'itinerari retorna la quantitat tirades fetes i quantes han donat un 6.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int contador1, contador6, contadorTirades;
            
            contadorTirades = 0;
            contador6 = 0;
            contador1 = 0;

            Random rnd = new Random();
            int tirada = rnd.Next(1, 7);

            if (tirada == 1)
            {
                contador1++;
                contadorTirades++;
            }
            else if (tirada == 6)
            {
                contador6++;
                contadorTirades++;
            }
            else
            {
                contadorTirades++;
            }

            while (contador1 != contador6)
            {

                if (tirada == 1)
                {
                    contador1++;
                    contadorTirades++;
                }
                else if (tirada == 6)
                {
                    contador6++;
                    contadorTirades++;
                }
                else
                {
                    contadorTirades++;
                }

                tirada = rnd.Next(1, 7);
            }
            Console.WriteLine($"Rolls: {contadorTirades}\nCrits: {contador6}");
        }
        
    }
}
