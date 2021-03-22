using System;

namespace  Animales
{
    class Program
    {
        static void Main(string[] args)
        {
            TiposDeAnimales t= new TiposDeAnimales();
            string opcion="";
            while (true)
            {
            Console.Clear();
            Console.WriteLine("\tMENU DE LOS ANIMALES");
            Console.WriteLine("\txxxxxxxxxxxxxxxxxxxx");
            Console.WriteLine("1- Mamiferos");
            Console.WriteLine("2- Aves");
            Console.WriteLine("3- Peces");
            Console.WriteLine("0- Salir");
            opcion=Console.ReadLine();

            switch (opcion)
            {
                case "1":
                t.ListaMamiferos();
                break;
                case "2":
                t.ListaAves();
                break;
                case "3":
                t.ListaDePeces();
                break;
                default:
                break;
            }
                if (opcion=="0")
                {
                    break;
                }
            }
            
        }
    }
}

