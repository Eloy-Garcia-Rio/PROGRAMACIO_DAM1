namespace Ex6
{
    internal class Program
    {
        /// <summary>
        /// Programa que, mitjançant els valors entrats per l'usuari, determina i retorna el resultat d'un partit.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string equipLocal, equipVisitant;
            int golsLocal, golsVisitant;
            string resultatPartit;

            Console.Clear();
            Console.WriteLine("Equip local?");
            equipLocal = Console.ReadLine();
            Console.WriteLine("Gols locals?");
            golsLocal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Equip visitant?");
            equipVisitant = Console.ReadLine();
            Console.WriteLine("Gols visitants?");
            golsVisitant = Convert.ToInt32(Console.ReadLine());

            resultatPartit = InformeResultat(equipLocal, golsLocal, equipVisitant, golsVisitant);

            Console.Clear();
            Console.WriteLine(resultatPartit);
        }

        /// <summary>
        /// Funció que compara els gols de cada equip i retorna un missatge diferent segons el resultat.
        /// </summary>
        /// <param name="nomEquipLocal">Nom de l'equip local</param>
        /// <param name="golsEquipLocal">Gols de l'equip local</param>
        /// <param name="nomEquipVisitant">Nom de l'equip visitant</param>
        /// <param name="golsEquipVisitant">Gols de l'equip visitant</param>
        /// <returns>Resultat del partit com a cadena de text.</returns>
        public static string InformeResultat(string nomEquipLocal, int golsEquipLocal, string nomEquipVisitant, int golsEquipVisitant)
        {
            string resultat;
            if (golsEquipLocal > golsEquipVisitant)
            {
                resultat = $"{nomEquipLocal} ha guanyat contra {nomEquipVisitant} amb un resultat de {golsEquipLocal} - {golsEquipVisitant}";
                return resultat ;
            }
            else if (golsEquipLocal < golsEquipVisitant)
            {
                resultat = $"{nomEquipLocal} ha perdut contra {nomEquipVisitant} amb un resultat de {golsEquipLocal} - {golsEquipVisitant}";
                return resultat;
            }
            else
            {
                resultat = $"{nomEquipLocal} ha empatat contra {nomEquipVisitant} amb un resultat de {golsEquipLocal} - {golsEquipVisitant}";
                return resultat;
            }
        }
    }
}
