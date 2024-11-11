using System.Globalization;

namespace Ex14
{
    internal class Program
    {
        /// <summary>
        /// Programa que, a partir del fitxer "tiquetsuper.txt", calcula el preu total de la compra.
        /// Al final de l'itinerari retorna el total de productes i l'import total de la compra.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int qProducte, nProductes;
            double preuProducte, preuTotal, preuArticle;
            string linia, nomProducte;
            StreamReader sr;

            Console.OutputEncoding = System.Text.Encoding.UTF8;

            qProducte = 0;
            nProductes = 0;
            preuArticle = 0;
            preuProducte = 0;
            preuTotal = 0;

            sr = new StreamReader("tiquetsuper.txt");
            linia = sr.ReadLine();
            nProductes = Convert.ToInt32(linia);
            linia = sr.ReadLine();

            for (string i = linia; i != null; i = sr.ReadLine())
            {
                nomProducte = i;
                qProducte = Convert.ToInt32(sr.ReadLine());
                preuProducte = Convert.ToDouble(sr.ReadLine());
                preuArticle = preuProducte * qProducte;
                preuTotal = preuTotal + preuArticle;
            }

            Console.WriteLine($"Productes comprats: {nProductes}\nImport total: {preuTotal:0.00}€");
        }
    }
}
