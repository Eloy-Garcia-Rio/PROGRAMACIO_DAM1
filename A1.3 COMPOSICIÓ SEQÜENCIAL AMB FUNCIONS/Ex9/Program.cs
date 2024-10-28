namespace Ex9
{
    internal class Program
    {
        /// <summary>
        /// Programa que, a partir d'un radi indicat per l'usuari, calcula i retorna el volum d'una esfera i l'àrea i el perímetre d'un cercle inscrit.
        /// </summary>
        /// <param name="args"></param>

        const double PI = 3.1416;

        static void Main(string[] args)
        {
            double radiEsfera;
            double volumEsfera, areaCercle, perimCercle;

            Console.Clear();
            Console.WriteLine("Quin és el radi de l'esfera?");
            radiEsfera = Convert.ToDouble(Console.ReadLine());

            volumEsfera = VolumEsfera(radiEsfera);
            areaCercle = AreaCercle(radiEsfera);
            perimCercle = PerimCercle(radiEsfera);

            Console.WriteLine($"Volum de l'esfera:\t\t{volumEsfera:0.00}");
            Console.WriteLine($"Àrea del cercle inscrit:\t\t{areaCercle:0.00}");
            Console.WriteLine($"Perímetre del cercle inscrit:\t\t{perimCercle:0.00}");

        }

        /// <summary>
        /// Funció que calcula el volum d'una esfera a partir del valor radi entrat per l'usuari.
        /// </summary>
        /// <param name="radius">Radi entrat per l'usuari.</param>
        /// <returns>Volum d'una esfera.</returns>
        public static double VolumEsfera(double radius)
        {
            double volume;
            volume = 4.0 / 3.0 * PI * Math.Pow(radius, 3);
            return volume;
        }

        /// <summary>
        /// Funció que calcula l'àrea d'un cercle inscrit mitjançant el radi entrat per l'usuari.
        /// </summary>
        /// <param name="radius">Radi entrat per l'usuari.</param>
        /// <returns>Àrea del cercle inscrit.</returns>
        public static double AreaCercle(double radius)
        {
            double area;
            area = PI * Math.Pow(radius, 2);
            return area;
        }

        /// <summary>
        /// Funció que calcula el perímetre d'un cercle inscrit a partir del radi assignat per l'usuari.
        /// </summary>
        /// <param name="radius">Radi entrat per l'usuari.</param>
        /// <returns>Perímetre del cercle inscrit.</returns>
        public static double PerimCercle(double radius)
        {
            double perimeter;
            perimeter = 2 * PI * radius;
            return perimeter;
        }
    }
}
