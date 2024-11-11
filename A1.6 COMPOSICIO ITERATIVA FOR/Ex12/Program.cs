using System.Globalization;

namespace Ex12
{
    internal class Program
    {
        /// <summary>
        /// Programa que, a partir del fitxer "coordenades2.txt", calcula si unes coordenades (x,y) es troben dins, fora o sobre una circumferència de radi indicat per l'usuari.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            double valorX, valorY, radi, distancia;
            string linia;
            StreamReader sr;


            CultureInfo.CurrentCulture = new CultureInfo("en-US");

            valorX = 0;
            valorY = 0;
            distancia = 0;

            Console.WriteLine("Valor del radi?");
            radi = Convert.ToDouble(Console.ReadLine());

            sr = new StreamReader("coordenades2.txt");
            linia = sr.ReadLine();

            for (string i = linia; i != null; i = sr.ReadLine())
            {
                valorX = Convert.ToDouble(i);
                valorY = Convert.ToDouble(sr.ReadLine());
                distancia = Distancia(valorX, valorY);

                if (distancia < radi)
                {
                    Console.WriteLine($"El punt ({valorX},{valorY}) es troba dins de la circumferència de radi {radi}");
                }
                else if (distancia > radi)
                {
                    Console.WriteLine($"El punt ({valorX},{valorY}) es troba fora de la circumferència de radi {radi}");
                }
                else
                {
                    Console.WriteLine($"El punt ({valorX},{valorY}) es troba sobre el perímetre de la circumferència de radi {radi}");
                }
            }
        }

        /// <summary>
        /// Funció que calcula la distancia entre la coordenada (x,y) i el punt (0,0) de la circumferència.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static double Distancia (double x, double y)
        {
            double resultat;
            resultat = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            return resultat;
        }
    }
}
