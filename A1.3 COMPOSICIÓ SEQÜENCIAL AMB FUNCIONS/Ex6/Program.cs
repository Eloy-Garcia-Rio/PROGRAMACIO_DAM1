namespace Ex6
{
    internal class Program
    {
        /// <summary>
        /// Programa que, a partir dels valors d'hores treballades, sou per hora i base imposable netrats per l'usuari,
        /// calcula i retorna el sou brut, la retenció i el sou net pertinents.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int horesTreballades;
            double souPerHora;
            double impostos;
            double souBrut, retencio, souNet;

            Console.Clear();
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Hores treballades?");
            horesTreballades = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sou per hora?");
            souPerHora = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Base imposable?");
            impostos = Convert.ToDouble(Console.ReadLine());

            souBrut = CalcularSouBrut(horesTreballades, souPerHora);
            retencio = CalcularRetencio(souBrut, impostos);
            souNet = CalcularSouNet(souBrut, retencio);

            Console.WriteLine($"Sou brut: {souBrut:0.00}€");
            Console.WriteLine($"Retenció d'impostos: {retencio:0.00}€");
            Console.WriteLine($"Sou net: {souNet:0.00}€");
        }

        /// <summary>
        /// Funció que calcula el sou net a partir del sou brut i de la retenció
        /// </summary>
        /// <param name="sBrut">Sou brut</param>
        /// <param name="reten">Retenció</param>
        /// <returns>Retorna el sou net</returns>
        /// <exception cref="NotImplementedException"></exception>
        private static double CalcularSouNet(double sBrut, double reten)
        {
            double souNet;
            souNet = sBrut - reten;
            return souNet;
        }

        /// <summary>
        /// Funció que calcula la retenció.
        /// </summary>
        /// <param name="salBrut">Salari brut</param>
        /// <param name="percentImpost">Impost en percentatge</param>
        /// <returns>Retorna la retenció</returns>
        private static double CalcularRetencio(double salBrut, double percentImpost)
        {
            double reten;
            reten = salBrut * percentImpost / 100;
            return reten;
        }

        /// <summary>
        /// Calcula el sou brut d'un treballador
        /// </summary>
        /// <param name="hores">Hores treballades</param>
        /// <param name="preuHora">Preu hora brut que cobra el treballador</param>
        /// <returns>Retorna el sou brut del treballador</returns>
        private static double CalcularSouBrut(int hores, double preuHora)
        {
            double sou;
            sou = hores * preuHora;
            return sou;
        }


    }
}
