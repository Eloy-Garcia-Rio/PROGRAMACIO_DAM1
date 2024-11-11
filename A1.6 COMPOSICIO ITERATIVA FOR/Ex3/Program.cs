namespace Ex3
{
    internal class Program
    {
        /// <summary>
        /// Programa que retorna tots els números enters trobats entre dos valors entrats per l'usuari, ambdòs inclosos.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int num1, num2;

            Console.WriteLine("Primer valor?");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Segon valor?");
            num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 < num2)
            {
                for (int i = num1; i <= num2; i++)
                {
                    Console.WriteLine(i);
                }
            }
            else if (num2 < num1)
            {
                for (int i = num2; i <= num1; i++)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                Console.WriteLine("Els valors entrats són idèntics.");
            }
        }
    }
}
