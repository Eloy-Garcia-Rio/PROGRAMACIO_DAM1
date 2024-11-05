namespace Ex5
{
    internal class Program
    {
        /// <summary>
        /// Programa que, mentres el valor entrat per l'usuari no sigui 0, porta un recompte i fa un sumatori dels valors entrats.
        /// A l'acabar l'itinerari retorna la mitjana de tots els valors.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            const int FI = 0;
            int num, sumatori, contador;
            double mitjana;

            contador = 0;
            sumatori = 0;
            num = Convert.ToInt32(Console.ReadLine());

            while (num != FI)
            {
                contador = contador + 1;
                sumatori = sumatori + num;
                num = Convert.ToInt32(Console.ReadLine());  
            }    

            if (contador == 0)
                Console.WriteLine("No s'ha entrat cap valor");

            else
            {
                mitjana = 1.00 * sumatori / contador;
                Console.WriteLine($"Mitjana: {mitjana}");
            }
        }
    }
}
