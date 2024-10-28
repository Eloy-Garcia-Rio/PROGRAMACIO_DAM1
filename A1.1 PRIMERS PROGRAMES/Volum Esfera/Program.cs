namespace Volum_Esfera
{
    internal class Program
    {
        /// <summary>
        /// Programa que et demana el radi d'una esfera en metres i et calcula el seu volum (4/3*PI*r*r*r)
        /// Compte que el programa té una errada. La saps trobar?
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {
            const double PI = 3.1416;                                               ///<-Constant de tipus coma flotant (PI). Literal de tipus  coma flotant (3.1416.
            double radi, volum;                                                     ///<-Variable de tipus coma flotant.
            Console.WriteLine("RADI DE L'ESFERA EN METRES?");                       ///<-Literal de tipus cadena de text.
            radi = Convert.ToDouble(Console.ReadLine());
            volum = 4.0 / 3.0 * PI * Math.Pow(radi, 3);                             ///<-Literal de tipus coma flotant (4.0,3.0). Literal de tipus enter (3).
            Console.WriteLine($"ESFERA DE RADI {radi} TÉ UN VOLUM DE {volum} m3");  ///<-Literal de tipus cadena de text.

                                                                                    ///Línies 14 i 15 són entrada.
                                                                                    ///Línia 16 és procés.
                                                                                    ///Línia 17 és sortida.

                                                                                    ///La variable volum està declarada com a double, però a la línia 16 el valor 3 és tractat com a int32. 
                                                                                    ///Afegirem decimals als valors fixes per convertir-los a double.

                                                                                    ///A la línia 17 hi ha un semicolon (;) extra.
        }
    }
}
