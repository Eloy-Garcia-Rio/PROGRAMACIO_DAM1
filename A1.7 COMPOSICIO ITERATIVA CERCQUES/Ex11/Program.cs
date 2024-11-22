namespace Ex11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string FILE_1 = "NOPERILL.TXT";
            const string FILE_2 = "PERILL1.TXT";
            const string FILE_3 = "PERILL2.TXT";

            int numSilurs, sumaTrams;
            bool esPerill;
            string linia;
            StreamReader sr;

            sumaTrams = 0;
            esPerill = false;

            Console.WriteLine("Selecciona un fitxer ( 1 | 2 | 3 )");
            int selector = Convert.ToInt32(Console.ReadLine());

            if (selector == 1)
                sr = new StreamReader(FILE_1);
            else if (selector == 2)
                sr = new StreamReader(FILE_2);
            else
                sr = new StreamReader(FILE_3);

            linia = sr.ReadLine();

            while (!esPerill && linia != null)
            {
                numSilurs = Convert.ToInt32(linia);
                esPerill = numSilurs == 0;

                if (!esPerill)
                {
                    sumaTrams = sumaTrams + numSilurs;
                    linia = sr.ReadLine();
                }
            }
            sr.Close();

            if (sumaTrams < 10)
                esPerill = true;
            Console.WriteLine(esPerill);
        }
    }
}
