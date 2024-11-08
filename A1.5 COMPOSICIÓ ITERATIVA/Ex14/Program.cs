namespace Ex14
{
    internal class Program
    {
        /// <summary>
        /// Programa que, mentres la línia llegida del fitxer no sigui buida, porta un recompte de la quantitat de billets premiats i l'import total dels premis associats.
        /// Al final del recorregut, el programa retorna la quantitat de billets premiats i l'import total dels premis associats.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int contadorBonus, premi, totalPremi;
            bool esBuit;
            string linia;
            StreamReader sr;

            Console.OutputEncoding = System.Text.Encoding.UTF8;

            contadorBonus = 0;
            premi = 0;
            totalPremi = 0;

            sr = new StreamReader("BONUS2.TXT");
            linia = sr.ReadLine();
            esBuit = linia == null;

            while (linia != null)
            {
                if (linia == "BONUS")
                {
                    contadorBonus++;
                    premi = Convert.ToInt32(sr.ReadLine());
                    totalPremi = totalPremi + premi;
                }

                linia = sr.ReadLine();
            }

            sr.Close();

            if (esBuit)
            {
                Console.WriteLine("El fitxer és buit.");
            }
            else
            {
                Console.WriteLine($"Billets guanyadors: {contadorBonus}\nTotal premis: {totalPremi:0.00}€");
            }
        }
    }
}
