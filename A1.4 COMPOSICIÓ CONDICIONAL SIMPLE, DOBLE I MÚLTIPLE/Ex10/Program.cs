namespace Ex10
{
    internal class Program
    {
        /// <summary>
        /// Programa que indica el segle al que pertany un any entrat per l'usuari.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int any;
            string segle;

            Console.WriteLine("Entra un any.");
            any = Convert.ToInt32(Console.ReadLine());

            segle = Segle(any);

            Console.WriteLine(segle);
        }

        /// <summary>
        /// Funció que clasifica l'any entrat en el segle corresponent.
        /// </summary>
        /// <param name="any">Any entrat per l'usuari.</param>
        /// <returns>Segle al qual pertany, o missatge d'error en cas de no pertànyer a cap segle.</returns>
        public static string Segle(int any)
        {
            string segle;
            
            if (any > 1700 && any <= 1800)
            {
                segle = $"L'any {any} pertany al segle XVIII.";
                return segle;
            }
            else if (any <= 1900)
            {
                segle = $"L'any {any} pertany al segle XIX.";
                return segle;
            }
            else if (any <= 2000)
            {
                segle = $"L'any {any} pertany al segle XX.";
                return segle;
            }
            else if (any <= 2100)
            {
                segle = $"L'any {any} pertany al segle XXI.";
                return segle;
            }
            else
            {
                segle = $"L'any {any} no és vàlid.";
                return segle;
            }
        }
    }
}
