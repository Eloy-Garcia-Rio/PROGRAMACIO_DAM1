namespace Ex3a
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string FILE_NAME = "NUMEROS2.TXT";

            int num, lastNum;
            string linia;
            bool esParell;
            StreamReader sr;

            lastNum = 0;
            sr = new StreamReader(FILE_NAME);
            linia = sr.ReadLine();
            num = Convert.ToInt32(linia);

            while (1.00 * Math.Abs(num) % 2 != 0.00 && linia != null)
            {
                lastNum = num;
                linia = sr.ReadLine();
                num = Convert.ToInt32(linia);
            }

            esParell = 1.00 * lastNum % 2 == 0.00;

            if (esParell)
                Console.WriteLine("Hi ha valors parells.");
            else
                Console.WriteLine("No hi ha valors parells.");
        }
    }
}
