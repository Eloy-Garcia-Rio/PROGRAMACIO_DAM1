namespace Ex10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string FILE_1 = "PLAGA.TXT";
            const string FILE_2 = "NOPLAGA.TXT";

            int numMusclos, counterTram;
            bool esPlaga;
            string linia;
            StreamReader sr;

            Console.WriteLine("Selecciona un fitxer ( a | b )");
            string selector = Console.ReadLine();
            if (selector == "a")
                sr = new StreamReader(FILE_1);
            else
                sr = new StreamReader(FILE_2);

            esPlaga = false;
            counterTram = 0;
            linia = sr.ReadLine();

            while (!esPlaga && linia != null)
            {
                numMusclos = Convert.ToInt32(linia);

                if (numMusclos > 500)
                    counterTram++;
                else
                    counterTram = 0;

                esPlaga = counterTram >= 5;

                if (!esPlaga)
                    linia = sr.ReadLine();
            }
            sr.Close();

            if (esPlaga)
                Console.WriteLine("Hi ha plaga.");
            else
                Console.WriteLine("No hi ha plaga.");
        }
    }
}
