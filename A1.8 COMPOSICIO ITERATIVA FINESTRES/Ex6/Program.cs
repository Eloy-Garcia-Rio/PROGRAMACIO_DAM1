namespace Ex6
{
    internal class Program
    {
        /// <summary>
        /// Programa que cerca i porta un recompte de les senyals de SOS trobades en un fitxer.
        /// Al final del recorregut retorna el resultat.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            const string FILE_1 = "SOS_NO.TXT";
            const string FILE_2 = "SOS_SI.TXT";
            const string SOS = "... --- ...";

            int nSenyals, nLectures;
            string linia, morse1, morse2, morse3;
            bool esPerill, esNovaSenyal;
            StreamReader sr;

            Console.WriteLine("Selecciona un fitxer ( 1 | 2 )");
            int selector = Convert.ToInt32(Console.ReadLine());

            if (selector == 1)
                sr = new StreamReader(FILE_1);
            else
                sr = new StreamReader(FILE_2);

            morse1 = ".";
            morse2 = ".";
            morse3 = ".";

            nLectures = 0;
            nSenyals = 0;
            esNovaSenyal = false;
            esPerill = false;
            linia = sr.ReadLine();

            if (linia != null)
            {
                morse1 = linia;
                linia = sr.ReadLine();

                if (linia != null)
                {
                    morse2 = linia;
                    linia = sr.ReadLine();

                    if (linia != null)
                    {
                        morse3 = linia;
                    }
                }
            }

            while (linia != null)
            {
                nLectures++;
                esPerill = (morse1 == SOS && morse2 == SOS) || (morse2 == SOS && morse3 == SOS);
                esNovaSenyal = (morse1 != SOS && esPerill) || (esPerill && nLectures == 1);

                if (esNovaSenyal)
                    nSenyals++;

                linia = sr.ReadLine();
                morse1 = morse2;
                morse2 = morse3;
                morse3 = linia;
            }
            sr.Close();

            if (nSenyals >= 1)
                Console.WriteLine($"S'han trobat {nSenyals} senyals de perill.");
            else
                Console.WriteLine("No s'ha trobat cap senyal de perill.");
        }
    }
}
