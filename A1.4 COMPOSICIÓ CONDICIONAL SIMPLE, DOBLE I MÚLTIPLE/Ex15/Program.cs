namespace Ex15
{
    internal class Program
    {
        /// <summary>
        /// Programa que demana hora, minut i segon per sumar 1s i retornar el resultat.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int hora, minut, segon;
            string horaIncrement;

            Console.WriteLine("Entra una hora.");
            hora = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Entra un minut.");
            minut = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Entra un segon.");
            segon = Convert.ToInt32(Console.ReadLine());

            horaIncrement = Incrementa1Segon(hora, minut, segon);

            Console.WriteLine(horaIncrement);
        }

        /// <summary>
        /// Funció que calcula la hora un cop es sumi 1s.
        /// </summary>
        /// <param name="h">Hora entrada per l'usuari.</param>
        /// <param name="m">Minut entrada per l'usuari.</param>
        /// <param name="s">Segon entrada per l'usuari.</param>
        /// <returns>Hora resultant en format hh:mm:ss, com a cadena de text.</returns>
        public static string Incrementa1Segon(int h, int m, int s)
        {
            string hhMMss;

            if ((s + 1 == 60) && (m + 1 == 60) && (h + 1 == 24))
            {
                s = 0;
                m = 0;
                h = 0;
                hhMMss = $"{h:00}:{m:00}:{s:00}";
                return hhMMss;
            }
            else if ((s + 1 == 60) && (m + 1 == 60))
            {
                s = 0;
                m = 0;
                h = h + 1;
                hhMMss = $"{h:00}:{m:00}:{s:00}";
                return hhMMss;
            }
            else if (s + 1 == 60)
            {
                s = 0;
                m = m + 1;
                hhMMss = $"{h:00}:{m:00}:{s:00}";
                return hhMMss;
            }
            else
            {
                s = s + 1;
                hhMMss = $"{h:00}:{m:00}:{s:00}";
                return hhMMss;
            }
        }
    }
}
