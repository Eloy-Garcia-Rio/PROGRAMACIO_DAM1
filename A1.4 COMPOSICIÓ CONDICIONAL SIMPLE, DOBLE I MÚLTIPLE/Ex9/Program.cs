namespace Ex9
{
    internal class Program
    {
        /// <summary>
        /// Programa que indica la nota qualificativa d'un alumne a partir de la nota d'examen i la nota de pràctiques.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            double notaExamen, notaPractiques;
            string notaQualitativa;

            Console.WriteLine("Nota de l'examen?");
            notaExamen = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nota de les pràctiques?");
            notaPractiques = Convert.ToDouble(Console.ReadLine());

            notaQualitativa = NotaQualitativa(notaExamen, notaPractiques);

            Console.WriteLine(notaQualitativa);
        }

        /// <summary>
        /// Funció que clasifica les diferents notes en les seves qualificacions corresponents.
        /// </summary>
        /// <param name="notaE">Nota d'exàmen.</param>
        /// <param name="notaP">Nota de pràctiques.</param>
        /// <returns>Nota qualificativa corresponent.</returns>
        public static string NotaQualitativa(double notaE, double notaP)
        {
            string notaQ;
            if ((notaE < 3.00 || notaP < 3.00) || ((notaE * 0.8 + notaP * 0.2) < 5.00))
            {
                notaQ = "Suspens";
                return notaQ;
            }
            else if ((notaE * 0.8 + notaP * 0.2) < 7.00)
            {
                notaQ = "Aprovat";
                return notaQ;
            }
            else if ((notaE * 0.8 + notaP * 0.2) < 9.00)
            {
                notaQ = "Notable";
                return notaQ;
            }
            else if ((notaE * 0.8 + notaP * 0.2) < 10.00)
            {
                notaQ = "Excel·lent";
                return notaQ;
            }
            else
            {
                notaQ = "Matrícula d'honor";
                return notaQ;
            }
        }
    }
}
