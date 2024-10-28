namespace Caramels
{
    internal class Program
    {
        /// <summary>
        /// Un professor ha decidit repartir un total de caramels entre els nens de la seva classe
        /// El professor vol repartir el ,àxim de caramels per nen, però vol que tots els nens tinguin el mateix # de caramels
        /// El professor es quedarà els caramels que sobrin.
        /// El programa ha de demanar el # de carmels i el # de nens i informar de
        /// a) quants caramels toquen per a cada nen
        /// b) quants caramels es quedarà el professor
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int nCaramels, nNens;                                                               ///<-Variables de tipus enter
            int caramelsPerNen, sobren;                                                         ///<-Variables de tipus enter
            Console.Clear();
            Console.WriteLine("QUANTS NENS?");                                                  ///<-Literal de tipus cadena de text                                              
            nNens = Convert.ToInt32(Console.ReadLine());                                        
            Console.WriteLine("QUANTS CARAMELS?");                                              ///<-Literal de tipus cadena de text
            nCaramels = Convert.ToInt32(Console.ReadLine());
            caramelsPerNen = nCaramels / nNens;
            sobren = nCaramels % nNens;                                                         
            Console.WriteLine($"TOTAL NENS : {nNens}\t\t TOTAL CARAMELS : {nCaramels}");        ///<-Literal de tipus cadena de text
            Console.WriteLine($"TOQUEN A {caramelsPerNen} CARAMELS PER CADA NEN");              ///<-Literal de tipus cadena de text
            Console.WriteLine($"EL PROFESSOR ES QUEDA {sobren} CARAMELS");                      ///<-Literal de tipus cadena de text

                                                                                                ///Línies 19 a 22 són entrada
                                                                                                ///Línies 23 i 24 són procés
                                                                                                ///Línies 25 a 27 són sortida
        }
    }
}
