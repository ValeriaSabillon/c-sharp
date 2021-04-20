using System;
using System.Collections.Generic;  
namespace Quien_Quiere_Ser_Millonario
{
    class Game
    {
    public List<Comodin> Listadecomodin { get; set; }
    public Game()
    {
        Listadecomodin = new List<Comodin>();

        Comodin a= new Comodin("Tienes",3,"comodines" );
       

        Listadecomodin.Add(a);
       
    }
   
        public void ListadePreguntas()
        { 
          Console.Clear();
          string nombre=""; 
          Console.WriteLine("Escriba su nombre:");
          nombre=Console.ReadLine();
       
          Console.WriteLine("\tLas reglas del juego:");
          Console.WriteLine("1-Lea con atencion las preguntas que apareceran y escriba la opcion correcta ");
          Console.WriteLine("2- tienes el derecho de utilizar 3 comodines");
          Console.WriteLine("3- Los comodines eliminan las respuestas incorrectas");
          Console.WriteLine("4- Si te equivocas con una pregunta pierdes el premio");
          Console.WriteLine("5- Tienes derecho a renunciar con la cantidad de premio que obtuvo");
        
         
          Console.WriteLine("XXXXXXXXXX ");
          Console.WriteLine("Empecemos");
          Console.WriteLine("XXXXXXXXXX");
          Console.WriteLine("\n");
          while(true){
          Console.Clear();

          string opcion="";
          Console.WriteLine("Pregunta 1");
          Console.WriteLine("Deseas utilizar un comodin presiona la letra f");
          Console.WriteLine( "___________________________________");
          Console.WriteLine("|Una tarjeta SD es un dispositivo de|");
          Console.WriteLine(" –––––––––––––––––––––––––––––––––––");
          Console.WriteLine("(A)Procesamiento de Audio (B)Compresion de video ");
          Console.WriteLine("(C)Comunicacion remota    (D)Memoria ");
          opcion=Console.ReadLine();
          if(opcion=="D"){
              Console.WriteLine("Opcion correcta");
          }
          else if(opcion=="f"){
              Console.WriteLine("Haz utilizado un comodin");
              Console.WriteLine("Respuesta correcta es:(D)Memoria ");
                                 
                        }
                        
              
                   }
          
          
              }
          
        }
       
}