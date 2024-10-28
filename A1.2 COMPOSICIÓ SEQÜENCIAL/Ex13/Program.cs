namespace Ex13
{
    internal class Program
    {
        /// <summary>
        /// Programa que desglossa un número de 4 dígits en els dígits que el conformen.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int anyOg, anyCopy;
            int digit1, digit2, digit3, digit4;

            Console.Clear();
            Console.WriteLine("Entra un any amb 4 dígits.");
            anyOg = Convert.ToInt32(Console.ReadLine());

            anyCopy = anyOg;
            digit1 = anyCopy % 10;
            anyCopy = anyCopy / 10;
            digit2 = anyCopy % 10;
            anyCopy = anyCopy / 10;
            digit3 = anyCopy % 10;
            anyCopy = anyCopy / 10;
            digit4 = anyCopy % 10;

            Console.WriteLine($"L'any {anyOg} es desglossa en: {digit4}; {digit3}; {digit2}; {digit1}");
        }
    }
}
