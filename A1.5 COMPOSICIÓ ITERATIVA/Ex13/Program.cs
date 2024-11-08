namespace Ex13
{
    internal class Program
    {
        /// <summary>
        /// Programa que, mentres la línia llegida del fitxer no sigui buida, porta un recompte de la quantitat de billets premiats, la quantitat de billets no premiats,
        /// aleatoritza el premi corresponent i recompta l'import total dels premis.
        /// Al finalitzar l'itinerari, el programa retorna el total de billets, el total de billets guanyadors, el percentatge de billets guanyadors
        /// i l'import total dels premis.
        /// </summary>
        /// <param name="args"></param>
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
                if (linia == "BONUS")
                {
                    contadorBonus++;
                    int premi = rnd.Next(1, 11);
                    totalPremis = totalPremis + premi;
                }
                else
                {
                    contadorNoBonus++;
                }

                linia = sr.ReadLine();
            }
            sr.Close();

            if (totalBillets == 0)
            {
                Console.WriteLine("El fitxer és buit.");
            }
            else
            {
                totalBillets = contadorBonus + contadorNoBonus;
                percentGuanyador = 1.00 * contadorBonus / totalBillets * 100;

                Console.WriteLine($"Total de billets: {totalBillets}\nBillets guanyadors: {contadorBonus}\nPercentatge guanyadors: {percentGuanyador:0.00}%\nTotal premis: {totalPremis:0.00}€");
            }
        }
    }
}
