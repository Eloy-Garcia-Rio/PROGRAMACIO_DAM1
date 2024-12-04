using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuPremier
{
    internal class Program
    {
        const string FILE_MATCHES = "MATCHES.TXT";
        const string FILE_TEAMS = "TEAMS.TXT";

        static void Main(string[] args)
        {
            ConsoleKeyInfo tecla;
            do
            {
                Console.Clear();
                ShowMenu();

                Console.Write("\nENTRA UNA OPCIÓ: ");
                tecla = Console.ReadKey();

                switch (tecla.Key)
                {
                    case ConsoleKey.D1:
                        DoSearchTeam(FILE_TEAMS);
                        break;
                    case ConsoleKey.D2:
                        DoGetGoalsTeam(FILE_TEAMS, FILE_MATCHES);
                        break;
                    case ConsoleKey.D3:
                        Console.WriteLine("\nNOT IMPLEMENTED YET.");
                        MsgNextScreen("PRESS ANY KEY TO CONTINUE");
                        break;
                    case ConsoleKey.D4:
                        Console.WriteLine("\nNOT IMPLEMENTED YET.");
                        MsgNextScreen("PRESS ANY KEY TO CONTINUE");
                        break;
                    case ConsoleKey.D0:
                        Console.WriteLine("\nEXITED PROGRAM.");
                        MsgNextScreen("PRESS ANY KEY TO CONTINUE");
                        break;
                    default:
                        Console.WriteLine("\nINVALID OPTION.");
                        MsgNextScreen("PRESS ANY KEY TO CONTINUE");
                        break;
                }
            } while (tecla.Key != ConsoleKey.D0);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="msg"></param>
        public static void MsgNextScreen(string msg)
        {
            Console.WriteLine(msg);
            Console.ReadKey();
        }

        /// <summary>
        /// Es demana per teclat l'abreviatura d'un equip i s'informa si l'equip existeix o no. 
        /// En cas que existeixi, es mostren les dades de l'equip
        /// </summary>
        /// <param name="fileTeams">fitxer que conté tots els equips</param>
        public static void DoSearchTeam(string fileTeams)
        {
            string searchResult, teamSearch;

            Console.WriteLine();
            Console.WriteLine("Enter the shorthand name of a team.");
            teamSearch = Console.ReadLine();

            searchResult = GetTeamName(fileTeams, teamSearch);

            if (searchResult == null)
                Console.WriteLine("The specified team does not exist.");
            else
                Console.WriteLine($"The full name of {teamSearch} is {searchResult}");

            MsgNextScreen("PRESS ANY KEY TO RETURN TO MAIN MENU");
        }

        /// <summary>
        /// Es retorna el nom de l'equip a partir de la seva abreviatura
        /// </summary>
        /// <param name="fileTeams">fitxer que conté els equips</param>
        /// <param name="abreviatura">abreviatura de l'equip a cercar</param>
        /// <returns>el nom de l'equip trobat en el fitxer fileTeams que tingui com a abreviatura el valor del paràmetre 'abreviatura'
        /// si l'equip no existeix, retornem null</returns>
        public static string GetTeamName(string fileTeams, string abreviatura)
        {
            bool isTeam;
            string line, teamShort, teamName;
            StreamReader sr;
            sr = new StreamReader(fileTeams);
            isTeam = false;
            teamName = " ";
            line = sr.ReadLine();

            while (!isTeam && line != null)
            {
                teamName = line;
                teamShort = sr.ReadLine();

                isTeam = teamShort == abreviatura;

                if (!isTeam)
                    line = sr.ReadLine();
            }
            sr.Close();

            if (isTeam)
                return teamName;
            else
                return null;
        }

        /// <summary>
        /// demana una abreviatura d'equip per teclat. 
        /// Si l'equip existeix, mostra el nom i els gols totals fet per l'equip en tots els seus partits.
        /// Si no existeix, es dona un msg d'error i tornem al menú principal
        /// </summary>
        /// <param name="fileTeams">fitxer que conté els equips</param>
        /// <param name="fileMatches">fitxer que conté els partits</param>
        public static void DoGetGoalsTeam(string fileTeams, string fileMatches)
        {
            string line, matchDate, homeTeam,  awayTeam, teamShort, teamSearch;
            int homeGoals, awayGoals, teamGoals;
            bool isHomeTeam, isAwayTeam;
            StreamReader sr;

            Console.WriteLine();
            Console.WriteLine("Enter the shorthand name of a team.");
            teamShort = Console.ReadLine();

            teamSearch = GetTeamName(fileTeams, teamShort);

            sr = new StreamReader(fileMatches);
            line = sr.ReadLine();
            teamGoals = 0;

            if (teamSearch == null)
                Console.WriteLine("The selected team does not exist.");
            else
                Console.WriteLine(teamSearch + " " + GetTeamGoals(fileMatches, teamShort));

            MsgNextScreen("PRESS ANY KEY TO RETURN TO MAIN MENU");
        }

        /// <summary>
        /// Es retorna el total de gols d'un equip a partir de la seva abreviatura
        /// </summary>
        /// <param name="fileTeams">fitxer que conté els partits</param>
        /// <param name="abreviatura">abreviatura de l'equip a cercar</param>
        /// <returns>missatge que conté el total de gols marcats per l'equip indicat</returns>
        public static string GetTeamGoals(string fileMatches, string abreviatura)
        {
            string line, matchDate, homeTeam, awayTeam;
            int homeGoals, awayGoals, teamGoals;
            bool isHomeTeam, isAwayTeam;
            StreamReader sr;

            sr = new StreamReader(fileMatches);
            line = sr.ReadLine();
            teamGoals = 0;

            while (line != null)
            {
                matchDate = line;
                homeTeam = sr.ReadLine();
                homeGoals = Convert.ToInt32(sr.ReadLine());
                awayTeam = sr.ReadLine();
                awayGoals = Convert.ToInt32(sr.ReadLine());

                isHomeTeam = abreviatura == homeTeam;
                isAwayTeam = abreviatura == awayTeam;

                if (isHomeTeam)
                    teamGoals = teamGoals + homeGoals;
                if (isAwayTeam)
                    teamGoals = teamGoals + awayGoals;

                line = sr.ReadLine();
            }
            sr.Close();

            return $"({abreviatura}) scored {teamGoals} goals this season.";
        }

        public static void ShowMenu()
        {
            Console.WriteLine("PREMIER LEAGUE");
            Console.WriteLine("----------------");
            Console.WriteLine("1- SEARCH TEAM");
            Console.WriteLine("2- SCORED GOALS");
            Console.WriteLine("3- MATCH RESULTS");
            Console.WriteLine("4- SEASON RESULTS");
            Console.WriteLine("0- EXIT");
        }
    }
}
