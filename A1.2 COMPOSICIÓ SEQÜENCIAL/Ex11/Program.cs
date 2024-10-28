namespace Ex11
{
    internal class Program
    {
        /// <summary>
        /// Programa que calcula la retenció d'impostos, el sou brut i net d'un treballador 
        /// a partir dels valors d'hores treballades, sou per hora i impostos aplicables introduits per l'usuari.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int horesTreballades;
            double souHora, impostos;
            double souBrut, souNet;
            double retencio;

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Clear();
            Console.WriteLine("Hores treballades?");
            horesTreballades = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sou per hora?");
            souHora = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Impostos aplicables?");
            impostos = Convert.ToDouble(Console.ReadLine());

            souBrut = horesTreballades * souHora;
            retencio = souBrut * (impostos / 100.00);
            souNet = souBrut - retencio;


            Console.Clear();
            Console.WriteLine($"Sou brut: {souBrut:0.00}€");
            Console.WriteLine($"Retenció d'impostos: {retencio:0.00}€");
            Console.WriteLine($"Sou net: {souNet:0.00}€");
        }
    }
}
