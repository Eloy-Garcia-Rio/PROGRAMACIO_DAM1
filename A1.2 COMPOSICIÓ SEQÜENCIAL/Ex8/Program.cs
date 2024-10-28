namespace Ex8
{
    internal class Program
    {
        /// <summary>
        /// Programa que converteix una quantitat de dòlars mitjançant un ratio de conversió determinat per l'usuari al seu equivalent en euros.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            double euros, dolars;
            double ratio;

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Clear();
            Console.WriteLine("Quants dòlars?");
            dolars = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ratio euros per dòlar?");
            ratio = Convert.ToDouble(Console.ReadLine());

            euros = dolars * ratio;

            Console.Clear();
            Console.WriteLine($"{dolars}$ són {euros}€");
        }
    }
}
