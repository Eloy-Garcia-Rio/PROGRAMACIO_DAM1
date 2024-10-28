namespace Ex4
{
    internal class Program
    {
        /// <summary>
        /// Programa que converteix de dòlars a euros utilitzant els valors de dòlar i ratio entrats per l'usuari i retorna el resultat.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            double dolars, euros;
            double usd2eur;

            Console.Clear();
            Console.OutputEncoding = System.Text.Encoding.UTF8; 
            Console.WriteLine("Quants dòlars?");
            dolars = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Quants euros són un dòlar?");
            usd2eur = Convert.ToDouble(Console.ReadLine());

            euros = Dollars2Euros(dolars, usd2eur);

            Console.WriteLine($"{dolars:0.00}$ equivalen a {euros:0.00}€");
        }

        /// <summary>
        /// Funció que transforma de dòlars a euros utilitzant els valors de dòlar i ratio entrats per l'usuari.
        /// </summary>
        /// <param name="qtyDollars">Quantitat de dòlars.</param>
        /// <param name="euro2Dollar">Ratio de conversió de dòlars a euros.</param>
        /// <returns>Valor en euros.</returns>
        public static double Dollars2Euros(double qtyDollars, double euro2Dollar) 
        {
            double qtyEuros;
            qtyEuros = qtyDollars * euro2Dollar;
            return qtyEuros;
        }
    }
}
