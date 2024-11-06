namespace Ex8
{
    internal class Program
    {
        /// <summary>
        /// Programa que, mentres la línia llegida del fitxer no sigui buida, emmagatzema el valor entrat més gran i el més petit.
        /// A l'acabar l'itinerari retorna els valors màxim i mínim entrats.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int num, max, min;
            string linia;
            bool esBuit;
            StreamReader sr;

            max = int.MinValue;
            min = int.MaxValue;

            sr = new StreamReader("NUMEROS.TXT");
            linia = sr.ReadLine();
            esBuit = linia == null;

            while (linia != null)
            {
                num = Convert.ToInt32(linia);

                if (max < num)
                    max = num;

                if (min > num)
                    min = num;

                linia = sr.ReadLine();
            }
            sr.Close();

            if (esBuit)
            {
                Console.WriteLine("El fitxer és buit.");
            }
            else
            {
                Console.WriteLine($"Número més gran: {max}\nNúmero més petit: {min}");
            }
        }
    }
}
