namespace Ex13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contadorBonus, contadorNoBonus, totalBillets, totalPremis;
            double percentGuanyador;
            string linia;
            StreamReader sr;
            Random rnd = new Random();

            Console.OutputEncoding = System.Text.Encoding.UTF8;

            percentGuanyador = 0;
            totalBillets = 0;
            totalPremis = 0;
            contadorBonus = 0;
            contadorNoBonus = 0;

            sr = new StreamReader("bonus.txt");
            linia= sr.ReadLine();

            while (linia != null)
            {
                if (linia == "NO BONUS")
                {
                    contadorNoBonus++;
                    linia = sr.ReadLine();
                }
                else if (linia == "BONUS")
                {
                    contadorBonus++;
                    int premi = rnd.Next(1, 11);
                    totalPremis = totalPremis + premi;
                    linia = sr.ReadLine();
                }
            }
            sr.Close();

            totalBillets = contadorBonus + contadorNoBonus;
            percentGuanyador = 1.00 * contadorBonus / totalBillets * 100;

            Console.WriteLine($"Total de billets: {totalBillets}\nBillets guanyadors: {contadorBonus}\nPercentatge guanyadors: {percentGuanyador:0.00}%\nTotal premis: {totalPremis:0.00}€");
        }
    }
}
