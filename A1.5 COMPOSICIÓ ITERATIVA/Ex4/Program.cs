namespace Ex4
{
    internal class Program
    {
        /// <summary>
        /// Programa que, mentres la línia llegida no sigui buida, porta un recompte dels valors positius i negatius trobats en un fitxer.
        /// A l'acabar l'itinerari retorna la quantitat de valors positius i negatius trobats.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int num, contadorPos, contadorNeg;
            string linia;
            bool esBuit;
            StreamReader sr;

            contadorPos = 0;
            contadorNeg = 0;

            sr = new StreamReader("NUMEROS.TXT");
            linia = sr.ReadLine();
            esBuit = linia == null;

            while (linia != null)
            {
                num = Convert.ToInt32(linia);

                if (num > 0)
                {
                    contadorPos++;
                    linia = sr.ReadLine();
                }
                else if (num < 0)
                {
                    contadorNeg++;
                    linia = sr.ReadLine();
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
                Console.WriteLine($"TOTAL POSITIUS: {contadorPos}\nTOTAL NEGATIUS: {contadorNeg}");
            }

        }
    }
}
