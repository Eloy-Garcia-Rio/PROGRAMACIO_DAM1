using System.Linq.Expressions;

namespace Ex2
{
    internal class Program
    {
        /// <summary>
        /// Programa que compara tres temperatures per comprovar que siguin totes iguals, i retorna diferents missatges segons si la condició es compleix o no.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int t1 = 25;
            int t2 = 25;
            int t3 = 25;
            bool iguals;
            iguals = t1 == t2 && t2 == t3 && t3 == t1;
            if (iguals)
            {
                Console.WriteLine("Les tres temperatures són iguals.");
            }
            else
            {
                Console.WriteLine("Les temperatures no són iguals.");
            }
        }
    }
}
