namespace Ex2
{
    internal class Program
    {
        /// <summary>
        /// Programa que calcula i retorna la distància entre dos punts mitjançants els valors x1,y1 i x2,y2 entrats per l'usuari.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int x1, y1;
            int x2, y2;
            double distancia;

            Console.Clear();
            Console.WriteLine("Valor X1?");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Valor Y1?");
            y1 = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("Valor X2?");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Valor Y2?");
            y2 = Convert.ToInt32(Console.ReadLine());

            distancia = CalculDistancia(x1, y1, x2, y2);

            Console.WriteLine($"Resultat: {distancia}");
        }

        /// <summary>
        /// Calcula la distància entre dos punts.
        /// </summary>
        /// <param name="x1">Valor X1</param>
        /// <param name="y1">Valor Y1</param>
        /// <param name="x2">Valor X2</param>
        /// <param name="y2">Valor Y2</param>
        /// <returns>Distància entra els dos punts.</returns>
        public static double CalculDistancia(int x1, int y1, int x2, int y2)
        {
            double distance;
            distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            return distance;
        }
    }

}
