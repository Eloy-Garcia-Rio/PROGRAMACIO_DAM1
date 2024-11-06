namespace Ex12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contadorIker, contadorAlex;
            string linia;
            bool esBuit;
            StreamReader sr;

            contadorIker = 0;
            contadorAlex = 0;

            sr = new StreamReader("alumnesDAMDAW.txt");
            linia = sr.ReadLine();
            esBuit = linia == null;

            while (linia != null)
            {
                if (linia == "Alex")
                {
                    contadorAlex++;
                    linia = sr.ReadLine();
                }
                else if (linia == "Iker")
                {
                    contadorIker++;
                    linia= sr.ReadLine();
                }
                else
                {
                    linia = sr.ReadLine();
                }
            }

            sr.Close();

            if (esBuit)
            {
                Console.WriteLine("El fitxer és buit.");
            }
            else
            {
                Console.WriteLine($"Alumnes anomenats Iker: {contadorIker}\nAlumnes anomenats Alex: {contadorAlex}");
            }

        }
    }
}
