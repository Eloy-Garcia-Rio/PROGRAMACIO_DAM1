// See https://aka.ms/new-console-template for more information

namespace HelloWorld
{ 
    internal class Program
    { 
        /// <summary>
        /// Escriu un programa que et demani el teu onm i et saludi dient HOLA + El teu nom
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {    
            string elTeuNom;                                        ///<-Variable de tipus cadena de text.
            Console.Clear();
            Console.WriteLine("COM ET DIUS? ");                     ///<-Literal de tipus cadena de text.
            elTeuNom = Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"HOLA {elTeuNom}");                  ///<-Literal de tipus cadena de text.

                                                                    ///Línies 15 i 16 són entrada.
                                                                    ///Línia 18 és sortida.
        }
    }
}