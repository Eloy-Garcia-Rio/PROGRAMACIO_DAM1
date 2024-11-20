namespace Ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string FITXER = "NUMEROS.TXT";

            int numUsuari, numLinia, numActual;
            bool esTrobat;
            string linia;
            StreamReader sr;

            esTrobat = false;
            numLinia = 0;
            numActual = 0;
            Console.WriteLine("Entra un número");
            numUsuari = Convert.ToInt32(Console.ReadLine());
            sr = new StreamReader(FITXER);
            linia = sr.ReadLine();
            numActual = Convert.ToInt32(linia);

            while (!esTrobat && linia != null)
            {
                esTrobat = numActual == numUsuari;

                numLinia++;
                linia = sr.ReadLine();
                numActual = Convert.ToInt32(linia);
            }

            sr.Close();

            if (esTrobat)
                Console.WriteLine($"El número {numUsuari} s'ha trobat a la línia {numLinia}");
            else
                Console.WriteLine($"El número {numUsuari} no s'ha trobat.");
        }
    }
}
