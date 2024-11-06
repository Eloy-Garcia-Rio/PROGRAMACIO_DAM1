namespace Ex16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valorX, valorY, radi, resultat;
            string liniaX, liniaY;
            StreamReader sr;

            resultat = 0;
            valorX = 0;
            valorY = 0;

            sr = new StreamReader("coordenades.txt");
            liniaX = sr.ReadLine();
            liniaY = sr.ReadLine();

            Console.WriteLine("Radi de la circumferència?");
            radi = Convert.ToDouble(Console.ReadLine());

            while (liniaX != null)
            {
                valorX = Convert.ToDouble(liniaX);
                valorY = Convert.ToDouble(liniaY);
                resultat = Math.Sqrt(Math.Pow(valorX, 2) + Math.Pow(valorY, 2));

                if (resultat < radi)
                {
                    Console.WriteLine($"El punt ({valorX},{valorY}) es troba dins de la circumferència.");
                    liniaX = sr.ReadLine();
                    liniaY = sr.ReadLine();
                }
                else if (resultat == radi)
                {
                    Console.WriteLine($"El punt ({valorX},{valorY}) es troba sobre el perímetre de la circumferència.");
                    liniaX = sr.ReadLine();
                    liniaY = sr.ReadLine();
                }
                else
                {
                    Console.WriteLine($"El punt ({valorX},{valorY}) es troba fora de la circumferència.");
                    liniaX = sr.ReadLine();
                    liniaY = sr.ReadLine();
                }
            }

            sr.Close();
        }
    }
}
