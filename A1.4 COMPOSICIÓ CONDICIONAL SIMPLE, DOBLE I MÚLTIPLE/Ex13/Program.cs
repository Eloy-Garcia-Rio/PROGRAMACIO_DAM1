namespace Ex13
{
    internal class Program
    {
        /// <summary>
        /// Programa que comprova i retorna si el número entrat és capicua o no.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int numero;
            bool esCapicua;

            Console.WriteLine("Entra un número de 3 xifres.");
            numero = Convert.ToInt32(Console.ReadLine());

            esCapicua = EsCapicua(numero);

            Console.WriteLine(esCapicua);
        }

        /// <summary>
        /// Funció que segmenta el número entrat per comprovar si és capicua o no.
        /// </summary>
        /// <param name="num">Número entrat per l'usuari.</param>
        /// <returns>Booleana que indica si el número és capicua o no.</returns>
        public static bool EsCapicua(int num)
        {
            int digitU, digitD, digitC;
            bool esCapicua;

            digitU = num % 10;
            digitD = (num / 10) % 10;
            digitC = num / 100;

            esCapicua = digitU == digitC;
            return esCapicua;
        }
    }
}
