namespace Ex11
{
    internal class Program
    {
        /// <summary>
        /// Programa que indica a quin sector d'una gràfica es trobaria un angle entrat per l'usuari.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            double angle;
            string quadrant;

            Console.WriteLine("Entra un angle");
            angle = Convert.ToDouble(Console.ReadLine());

            quadrant = QuadrantAngle(angle);

            Console.WriteLine(quadrant);
        }

        /// <summary>
        /// Funció que calcula a quin quadrant es troba l'angle entrat.
        /// </summary>
        /// <param name="angle">Angle entrat per l'usuari.</param>
        /// <returns>El quadrant al qual pertany.</returns>
        public static string QuadrantAngle(double angle)
        {
            string quadrant;

            if ((angle >= 0.00 && angle <= 90.00) || (angle >= -360.00 && angle < -270.00))
            {
                quadrant = $"Un angle de {angle:0.00}º es trobarà al quadrant I.";
                return quadrant;
            }
            else if ((angle > 90.00 && angle <= 180.00) || (angle >= -270.00 && angle < -180.00))
            {
                quadrant = $"Un angle de {angle:0.00}º es trobarà al quadrant II.";
                return quadrant;
            }
            else if ((angle > 180.00 && angle <= 270.00) || (angle >= -180.00 && angle < -90.00))
            {
                quadrant = $"Un angle de {angle:0.00}º es trobarà al quadrant III.";
                return quadrant;
            }
            else if ((angle > 270.00 && angle <= 360.00) || (angle >= -90.00 && angle < 0.00))
            {
                quadrant = $"Un angle de {angle:0.00}º es trobarà al quadrant IV.";
                return quadrant;
            }
            else
            {
                quadrant = "L'angle introduit no és vàlid.";
                return quadrant;
            }
        }
    }
}
