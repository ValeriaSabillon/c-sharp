using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Quien_Quiere_Ser_Millonario
{
    class Program
    {
        static void Main(string[] args)
        {
            Game j= new Game();
            string opcion="";
            while(true)
            {
            Console.BackgroundColor=ConsoleColor.Yellow;
            Console.Clear();
            Console.ForegroundColor=ConsoleColor.Black;
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine("\t         ********** *** ********** *        * *           * ********** *        * *** *******     *****");
            Console.WriteLine("\t         *        *  *             * *      *  *         *  *          * *      *  *   *     *   *      *");
            Console.WriteLine("\t         *        *  *  *          *   *    *   *       *   *          *   *    *  *   *      * *        *  ");
            Console.WriteLine("\t         *********   *  ******     *     *  *    *     *    ******     *     *  *  *   *      * *         *" );
            Console.WriteLine("\t         *        *  *  *          *      * *     *   *     *          *      * *  *   *      *  *       *");
            Console.WriteLine("\t         *        *  *  *          *       **      * *      *          *       **  *   *     *    *     *");
            Console.WriteLine("\t         ********** *** ********** *        *       *       ********** *        * *** *******      *****  ");
            Console.WriteLine("\n");
            Console.WriteLine("     *     ***  *   * *** *** *   *    ***  *   * *** *** **** ***   **** *** ****   *     * *** *   *    ***  *    *     *      **** *** ***" );
            Console.WriteLine("    * *   *   * *   *  *  *   **  *   *   * *   *  *  *   *  * *     *    *   *  *   *     *  *  *   *   *   * * *  *    * *     *  *  * *   *");
            Console.WriteLine("   *****  * * * *   *  *  *** * * *   * * * *   *  *  *** ***  ***     *  **  ***    **  * *  *  *   *   *   * *  * *   *****    ***   * *   *");
            Console.WriteLine("  *     * *   * *   *  *  *   *  **   *   * *   *  *  *   * *  *        * *   * *    * * * *  *  *   *   *   * *   **  *     *   * *   * *   *");
            Console.WriteLine(" *       * *** * ***  *** *** *   *    *** * ***  *** *** *  * ***   **** *** *  *   *  *  * *** *** ***  ***  *    * *       *  *  * *** *** ");
            Console.WriteLine("\n");
            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            Console.ForegroundColor=ConsoleColor.Blue;

            Console.WriteLine("                                                        MENU");
            Console.ForegroundColor=ConsoleColor.Black;
            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            Console.WriteLine("\n1- Comenzar Juego");
            Console.WriteLine("2- Salir del Juego");
            opcion=Console.ReadLine();
            switch (opcion)
            {
                case "1":
                j.ListadePreguntas();
                Console.Clear();

                break;
                default:
                break;
            }
                if(opcion=="2")
                {
                    Console.Clear();

                    break;
                }
            }
         }
    }
}
