namespace Ex5
{
    internal class Program
    {
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
