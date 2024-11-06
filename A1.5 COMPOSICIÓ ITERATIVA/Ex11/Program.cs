namespace Ex11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int operand1, operand2, contador;
            int sumaUsuari, restaUsuari, producteUsuari, divisioUsuari;
            int sumaReal, restaReal, producteReal, divisoReal;

            contador = 0;

            Random rand = new Random();
            operand1 = rand.Next(1, 101);
            operand2 = rand.Next(1, 101);

            sumaReal = operand1 + operand2;
            restaReal = operand1 - operand2;
            producteReal = operand1 * operand2;
            divisoReal = operand1 / operand2;

            Console.WriteLine("Resultat de la suma?");
            sumaUsuari = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Resultat de la resta?");
            restaUsuari = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Resultat de la multiplicació?");
            producteUsuari = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Resultat de la divisió?");
            divisioUsuari = Convert.ToInt32(Console.ReadLine());

            while (sumaUsuari != sumaReal || restaUsuari != restaReal || producteUsuari != producteReal || divisioUsuari != divisoReal)
            {
                Console.Clear();
                Console.WriteLine("Torna-ho a intentar");

                contador++;

                operand1 = rand.Next(1, 101);
                operand2 = rand.Next(1, 101);

                sumaReal = operand1 + operand2;
                restaReal = operand1 - operand2;
                producteReal = operand1 * operand2;
                divisoReal = operand1 / operand2;

                Console.ReadKey();

                Console.WriteLine("Resultat de la suma?");
                sumaUsuari = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Resultat de la resta?");
                restaUsuari = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Resultat de la multiplicació?");
                producteUsuari = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Resultat de la divisió?");
                divisioUsuari = Convert.ToInt32(Console.ReadLine());

            }
            contador++;
            Console.WriteLine($"Felicitats! Has endevinat el resultat amb {contador} intents.");
        }
    }
}
