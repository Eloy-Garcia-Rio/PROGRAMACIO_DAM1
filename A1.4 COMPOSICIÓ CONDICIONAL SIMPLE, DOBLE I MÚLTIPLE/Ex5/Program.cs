namespace Ex5
{
    internal class Program
    {
        /// <summary>
        /// Programa que indica si el número entrat per l'usuari és parell i/o és múltiple de 7.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int numero;
            bool esParell, esMult7;

            Console.WriteLine("Entra un número");
            numero = Convert.ToInt32(Console.ReadLine());

            esParell = EsParell(numero);
            esMult7 = EsMulti7(numero);

            if (esParell)
            {
                Console.WriteLine($"El número {numero} és parell.");
            }
            else
            {
                Console.WriteLine($"El número {numero} és senar.");
            }

            if (esMult7)
            {
                Console.WriteLine($"El número {numero} és múltiple de 7.");
            }
            else
            {
                Console.WriteLine($"El número {numero} no és múltiple de 7.");
            }
        }

        /// <summary>
        /// Funció que comprova si el número entrat és parell.
        /// </summary>
        /// <param name="n">Número de l'usuari.</param>
        /// <returns>Booleana que indica si es parell o no.</returns>
        public static bool EsParell(int n)
        {
            bool esParell;
            esParell = n % 2 == 0;
            return esParell;
        }

        /// <summary>
        /// Funció que comprova si el número entrat és múltiple de 7.
        /// </summary>
        /// <param name="n">Número de l'usuari.</param>
        /// <returns>Booleana que indica si es múlltiple de 7 o no.</returns>
        public static bool EsMulti7(int n)
        {
            bool esMult7;
            esMult7 = n % 7 == 0;
            return esMult7;
        }
    }
}
