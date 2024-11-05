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
            StreamReader sr;

            contadorPos = 0;
            contadorNeg = 0;
            sr = new StreamReader("NUMEROS.TXT");
            linia = sr.ReadLine();
            num = Convert.ToInt32(linia);

            while (linia != null)
            {
                if (num > 0)
                {
                    contadorPos = contadorPos + 1;
                    linia = sr.ReadLine();
                    num = Convert.ToInt32(linia);
                }
                else
                {
                    contadorNeg = contadorNeg + 1;
                    linia = sr.ReadLine();
                    num = Convert.ToInt32(linia);
                }
            }
            sr.Close();
            Console.WriteLine($"TOTAL POSITIUS: {contadorPos}\nTOTAL NEGATIUS: {contadorNeg}");
        }
    }
}
