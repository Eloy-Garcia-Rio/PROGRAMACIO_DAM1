namespace Ex8
{
    internal class Program
    {
        /// <summary>
        /// Programa que, a partir de l'hora entrada en format hhmmss, la segmenta en hores, minuts i segons i comprova que els valors siguin correctes.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int horaSencera, hora, minut, segon;
            bool esValida;

            Console.WriteLine("Quina és l'hora actual (format hhmmss?");
            horaSencera = Convert.ToInt32(Console.ReadLine());

            hora = horaSencera / 10000;
            minut = horaSencera / 100 % 100;
            segon = horaSencera % 100;

            esValida = HoraValida(hora, minut, segon);

            Console.WriteLine(esValida);
        }

        /// <summary>
        /// Funció que comprova si els valors hora, minut i segon estan en un format correcte.
        /// </summary>
        /// <param name="h">hora</param>
        /// <param name="m">minut</param>
        /// <param name="s">segon</param>
        /// <returns>Booleana que indica si el valor entrat és vàlid o no.</returns>
        public static bool HoraValida(int h, int m, int s)
        {
            bool validHhMmSs;

            validHhMmSs = (h >= 0 && h <= 23) && (m >= 0 && m <= 59) && (s >= 0 && s <= 59);
            return validHhMmSs;
        }
    }
}
