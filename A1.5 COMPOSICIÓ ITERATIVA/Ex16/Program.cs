using System.Globalization;

namespace Ex16
{
    internal class Program
    {
        /// <summary>
        /// Programa que, mentres la línia llegida del fitxer no sigui buida, determina si una coordenada (x,y) es troba dins, fora o sobre una circumferència de radi determinat
        /// per l'usuari. Els valors trobats a les línies senars corresponen a X, mentres que les línies parelles corresponen a Y.
        /// Durant l'itinerari, el programa retorna el missatge corresponent a cada cas.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            double valorX, valorY, radi, resultat;
            string liniaX, liniaY;
            StreamReader sr;

            CultureInfo.CurrentCulture = new CultureInfo("en-US");

            resultat = 0;
            valorX = 0;
            valorY = 0;

            sr = new StreamReader("coordenades.txt");
            liniaX = sr.ReadLine();
            liniaY = sr.ReadLine();

            Console.WriteLine("Radi de la circumferència?");
            radi = Convert.ToDouble(Console.ReadLine());

            while (liniaX != null)
            {
                valorX = Convert.ToDouble(liniaX);
                valorY = Convert.ToDouble(liniaY);
                resultat = Math.Sqrt(Math.Pow(valorX, 2) + Math.Pow(valorY, 2));

                if (resultat < radi)
                {
                    Console.WriteLine($"El punt ({valorX},{valorY}) es troba dins de la circumferència.");
                }
                else if (resultat == radi)
                {
                    Console.WriteLine($"El punt ({valorX},{valorY}) es troba sobre el perímetre de la circumferència.");
                }
                else
                {
                    Console.WriteLine($"El punt ({valorX},{valorY}) es troba fora de la circumferència.");
                }

                liniaX = sr.ReadLine();
                liniaY = sr.ReadLine();
            }

            sr.Close();
        }
    }
}
