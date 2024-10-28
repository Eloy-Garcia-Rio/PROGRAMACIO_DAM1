namespace Ex7
{
    internal class Program
    {
        /// <summary>
        /// Programa que, a partir de la velocitat entrada per l'usuari, determina i retorna el tipus de sanció aplicable (si escau).
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int velocitat;
            string missatge;

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("A quina velocitat vas?");
            velocitat = Convert.ToInt32 (Console.ReadLine());

            missatge = Sancio(velocitat);

            Console.WriteLine(missatge);
        }

        /// <summary>
        /// Funció que compara la velocitat entrada per l'usuari amb els diferents trams de sanció.
        /// </summary>
        /// <param name="velocitat">Velocitat entrada per l'usuari.</param>
        /// <returns>Missatge pertinent al resultat.</returns>
        public static string Sancio(int velocitat)
        {
            bool tram1, tram2, tram3;
            string missatge;
            tram1 = velocitat >= 80 && velocitat <= 99;
            tram2 = velocitat >= 100 && velocitat <= 129;
            tram3 = velocitat >= 130;

            if (tram1)
            {
                missatge = "Velocitat excessiva pertinent a tram 1. Sanció estipulada: 100€";
                return missatge;
            }
            else if (tram2)
            {
                missatge = "Velocitat excessiva pertinent a tram 2. Sanció estipulada: 300€";
                return missatge;
            }
            else if (tram3)
            {
                missatge = "Velocitat excessiva pertinent a tram 3. Sanció estipulada: 600€ i retirada del carnet.";
                return missatge;
            }
            else
            {
                missatge = "Velocitat adequada. No s'aplicarà cap sanció.";
                return missatge;
            }
        }
    }
}
