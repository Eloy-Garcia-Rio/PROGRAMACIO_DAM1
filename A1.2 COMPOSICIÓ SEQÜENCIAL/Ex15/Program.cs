namespace Ex15
{
    internal class Program
    {
        /// <summary>
        /// Programa que descomposa seqüencialment una quantitat d'euros entrada per l'usuari en la quantitat de billets i monedes d'euro més eficient.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            double eurosRebuts;
            int centimsRebuts, sobrant;
            int canvi100, canvi50, canvi20, canvi10, canvi5, canvi2, canvi1, canvi050, canvi020, canvi010, canvi005, canvi002, canvi001;

            Console.Clear();
            Console.WriteLine("Efectiu aportat?");
            eurosRebuts = Convert.ToDouble(Console.ReadLine());

            centimsRebuts = (int)(eurosRebuts * 100);
            canvi100 = centimsRebuts / 10000;
            sobrant = centimsRebuts % 10000;
            canvi50 = sobrant / 5000;
            sobrant = sobrant % 5000;
            canvi20 = sobrant / 2000;
            sobrant = sobrant % 2000;
            canvi10 = sobrant / 1000;
            sobrant = sobrant % 1000;
            canvi5 = sobrant / 500;
            sobrant = sobrant % 500;
            canvi2 = sobrant / 200;
            sobrant = sobrant % 200;
            canvi1 = sobrant / 100;
            sobrant = sobrant % 100;
            canvi050 = sobrant / 50;
            sobrant = sobrant % 50;
            canvi020 = sobrant / 20;
            sobrant = sobrant % 20;
            canvi010 = sobrant / 10;
            sobrant = sobrant % 10;
            canvi005 = sobrant / 5;
            sobrant = sobrant % 5;
            canvi002 = sobrant / 2;
            sobrant = sobrant % 2;
            canvi001 = sobrant / 1;

            Console.Clear();
            Console.WriteLine($"Billets de 100: {canvi100}");
            Console.WriteLine($"Billets de 50: {canvi50}");
            Console.WriteLine($"Billets de 20: {canvi20}");
            Console.WriteLine($"Billets de 10: {canvi10}");
            Console.WriteLine($"Billets de 5: {canvi5}");
            Console.WriteLine($"Monedes de 2: {canvi2}");
            Console.WriteLine($"Monedes de 1: {canvi1}");
            Console.WriteLine($"Monedes de 0,50: {canvi050}");
            Console.WriteLine($"Monedes de 0,20: {canvi020}");
            Console.WriteLine($"Monedes de 0,10: {canvi010}");
            Console.WriteLine($"Monedes de 0,05: {canvi005}");
            Console.WriteLine($"Monedes de 0,02: {canvi002}");
            Console.WriteLine($"Monedes de 0,01: {canvi001}");
        }
    }
}
