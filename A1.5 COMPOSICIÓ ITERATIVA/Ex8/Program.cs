namespace Ex8
{
    internal class Program
    {
        /// <summary>
        /// Programa que, mentres la línia llegida no sigui buida, emmagatzema el valor entrat més gran i el més petit.
        /// A l'acabar l'itinerari retorna els valors màxim i mínim entrats.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int num, max, min;
            string linia;
            StreamReader sr;

            max = int.MinValue;
            min = int.MaxValue;
            sr = new StreamReader("NUMEROS.TXT");
            linia = sr.ReadLine();
            num = Convert.ToInt32(linia);

            while (linia != null)
            {
                if (max < num)
                    max = num;

                if (min > num)
                    min = num;

                linia = sr.ReadLine();
                num = Convert.ToInt32(linia);
            }
            sr.Close();
            Console.WriteLine($"Número més gran: {max}\nNúmero més petit: {min}");
        }
    }
}
