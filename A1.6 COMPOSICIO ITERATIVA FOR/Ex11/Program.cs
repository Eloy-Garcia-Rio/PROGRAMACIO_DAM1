namespace Ex11
{
    internal class Program
    {
        /// <summary>
        /// Programa que, a partir del fitxer "BONUS3.TXT", comprova la quantitat de billets, quants d'ells són premiats i l'import total dels premis.
        /// Al final de l'itinerari retorna el total de billets, quants d'ells són premiats i l'import total dels premis.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int premi, totalPremis, counterBillets, counterPremis;
            string linia;
            StreamReader sr;

            Console.OutputEncoding = System.Text.Encoding.UTF8;

            counterBillets = 0;
            counterPremis = 0;
            premi = 0;
            totalPremis = 0;
            sr = new StreamReader("BONUS3.TXT");
            linia = sr.ReadLine();

            for (string i = linia; i != null; i = sr.ReadLine())
            {
                if (i == "BONUS")
                {
                    counterPremis++;
                    premi = Convert.ToInt32(sr.ReadLine());
                    totalPremis = totalPremis + premi;
                }
                counterBillets++;
            }

            Console.WriteLine($"Total billets: {counterBillets}\nTotal premis: {counterPremis}\nImport total premis: {totalPremis:0.00}€");
        }
    }
}
