namespace Ex9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string FILE_1 = "TIQUET.TXT";
            const string FILE_2 = "TIQUET2_COMPRA.TXT";
            const string FILE_3 = "TIQUET3_COMPRA_SANA.TXT";

            Console.OutputEncoding = System.Text.Encoding.UTF8;

            int numProducte, counterColesterol;
            double preuUnitat, preuProducte, preuTotal;
            bool teColesterol, esInsalubre;
            string linia, nomProducte, producteColesterol;
            StreamReader sr;

            Console.WriteLine("Selecciona un fitxer ( 1 | 2 | 3 )");
            int selector = Convert.ToInt32(Console.ReadLine());
            if (selector == 1)
                sr = new StreamReader(FILE_1);
            else if (selector == 2)
                sr = new StreamReader(FILE_2);
            else
                sr = new StreamReader(FILE_3);

            producteColesterol = " ";
            counterColesterol = 0;
            preuProducte = 0;
            preuTotal = 0;
            preuUnitat = 0;
            teColesterol = false;
            esInsalubre = false;
            linia = sr.ReadLine();

            while (!esInsalubre && linia != null)
            {
                nomProducte = linia;

                teColesterol = nomProducte.Contains("PIZZ") || nomProducte.Contains("EMBOTIT");

                if (teColesterol)
                {
                    counterColesterol++;
                    producteColesterol = nomProducte;
                }

                esInsalubre = counterColesterol > 1;

                if (!esInsalubre)
                {
                    numProducte = Convert.ToInt32(sr.ReadLine());
                    preuUnitat = Convert.ToDouble(sr.ReadLine());

                    preuProducte = numProducte * preuUnitat;
                    preuTotal = preuTotal + preuProducte;

                    linia = sr.ReadLine();
                }
            }
            sr.Close();

            if (esInsalubre)
                Console.WriteLine("La llista conté massa productes rics en colesterol.");
            else
                Console.WriteLine($"Import total: {preuTotal:0.00}€");

            if (counterColesterol == 1)
                Console.WriteLine($"Producte ric en colesterol trobat: {producteColesterol}");
            if (counterColesterol == 0)
                Console.WriteLine("Compra sana!");

        }
    }
}
