using System.Linq.Expressions;

namespace Ex4
{
    internal class Program
    {
        /// <summary>
        /// Programa que comprova si les tres temperatures es troben en escala creixent estricte.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int t1 = 24;
            int t2 = 25;
            int t3 = 26;
            bool ordreCreixent;
            ordreCreixent = t1 < t2 && t2 < t3 && t3 > t1;
            if (ordreCreixent)
            {
                Console.WriteLine("Les temperatures estan en ordre creixent estricte.");
            }
            else
            {
                Console.WriteLine("Les temperatures no estan en ordre creixent estricte.");
            }
        }
    }
}
