using System;
using System.Collections.Generic;  
namespace Quien_Quiere_Ser_Millonario
{
    class Game
    {
        public void ListadePreguntas()
        { 
         Console.Clear();
        Console.BackgroundColor=ConsoleColor.Blue;

          

          while(true){
          Console.Clear();
          string opcion="";
          string nombre=""; 
          int comodin=3;
          int re=0;
          
          Console.WriteLine("Escriba su nombre:");
          nombre=Console.ReadLine();
          Console.WriteLine("Las reglas del juego:");
          Console.WriteLine("1-Lea con atencion las preguntas que apareceran y escriba la opcion correcta ");
          Console.WriteLine("2- tienes el derecho de utilizar 3 comodines");
          Console.WriteLine("3- Los comodines eliminan las respuestas incorrectas");
          Console.WriteLine("4- Si te equivocas con una pregunta pierdes el premio");
          Console.WriteLine("5- Tienes derecho a renunciar con la cantidad de premio que obtuvo");
          
          Console.WriteLine("XXXXXXXXXX ");
          Console.WriteLine("Empecemos");
          Console.WriteLine("XXXXXXXXXX");
          Console.WriteLine("\n");
           Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");

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
              Console.WriteLine("Desea Continuar");
              opcion=Console.ReadLine();
              
          }else if(opcion=="f"){
              comodin=comodin-1;
              re=comodin;

              Console.WriteLine("Haz utilizado un comodin, te quedan:");
              Console.WriteLine(re);
              Console.WriteLine("Respuesta correcta es:(D)Memoria ");
              Console.WriteLine("Desea Continuar");
              opcion=Console.ReadLine();
              
                                 
            }
          if (opcion=="si"){
           Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");

          Console.WriteLine("Pregunta 2");
          Console.WriteLine("Deseas utilizar un comodin presiona la letra f");
          Console.WriteLine( "_______________________________________________________________________________");
          Console.WriteLine("|El sistema electoral para determinar las personas que ocuparan cargos publicos:|");
          Console.WriteLine(" –––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––");
          Console.WriteLine("(A)Sufragio     (B)Adagio ");
          Console.WriteLine("(C)Naufragio    (D)Prestigio ");
          opcion=Console.ReadLine();
          }if(opcion=="A"){
            Console.WriteLine("Opcion correcta");
              Console.WriteLine("Desea Continuar");
              opcion=Console.ReadLine();
          }else if(opcion=="f"){
            
              comodin=comodin-1;
              re=comodin;
              Console.WriteLine("Haz utilizado un comodin, te quedan:");
              Console.WriteLine(re);
              Console.WriteLine("Respuesta correcta es:(A)Sufragio");
               Console.WriteLine("Desea Continuar");
              opcion=Console.ReadLine();
                                      
            } if (opcion=="si"){
          Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
          Console.WriteLine("Pregunta 3");
          Console.WriteLine("Deseas utilizar un comodin presiona la letra f");
          Console.WriteLine( "____________________________________________________________________________");
          Console.WriteLine("|Con que material esculpió Miguel Angel (La Piedad) ubicada en el Vaticano?:|");
          Console.WriteLine(" ––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––");
          Console.WriteLine("(A)Bronce       (B)Marmol ");
          Console.WriteLine("(C)Madera       (D)Yeso ");
          opcion=Console.ReadLine();
          }if(opcion=="B"){
            Console.WriteLine("Opcion correcta");
              Console.WriteLine("Desea Continuar");
              opcion=Console.ReadLine();
          } else if(opcion=="f" && re>=1){
              comodin=comodin-1;
              re=comodin;
              Console.WriteLine("Haz utilizado un comodin, te quedan:");
              Console.WriteLine(re);
              Console.WriteLine("Respuesta correcta es:(B)fMarmol");
              Console.WriteLine("Desea Continuar");
              opcion=Console.ReadLine();            
              
                }if (opcion=="si"){
          Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
          Console.WriteLine("Pregunta 4");
          Console.WriteLine("Deseas utilizar un comodin presiona la letra f");
          Console.WriteLine( "______________________________________");
          Console.WriteLine("|Cual es el idioma oficial de Israel?:|");
          Console.WriteLine(" ––––––––––––––––––––––––––––––––––––––");
          Console.WriteLine("(A)Japones      (B)Griego ");
          Console.WriteLine("(C)Hebreo       (D)Chino ");
          opcion=Console.ReadLine();
          } if(opcion=="f" && re>=0){
                        
              Console.WriteLine("A L E R TA");
              Console.WriteLine("Ya no puedes usar comodines");
               Console.WriteLine("Desea Continuar");
              opcion=Console.ReadLine();
          }if(opcion=="si"){
              Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
          Console.WriteLine("Pregunta 4");
          Console.WriteLine(" YA NO HAY COMODINES");
          Console.WriteLine( "______________________________________");
          Console.WriteLine("|Cual es el idioma oficial de Israel?:|");
          Console.WriteLine(" ––––––––––––––––––––––––––––––––––––––");
          Console.WriteLine("(A)Japones      (B)Griego ");
          Console.WriteLine("(C)Hebreo       (D)Chino ");
          opcion=Console.ReadLine();
            
          } if(opcion=="C"){
              Console.WriteLine("Opcion correcta");
              Console.WriteLine("Desea Continuar");
              opcion=Console.ReadLine();

          } if(opcion=="f" && re>1){
              comodin=comodin-1;
              re=comodin;
              Console.WriteLine("Haz utilizado un comodin, te quedan:");
              Console.WriteLine(re);
              Console.WriteLine("Respuesta correcta es:(C)Hebreo");
              Console.WriteLine("Desea Continuar");
              opcion=Console.ReadLine(); 
                  
              }if (opcion=="si"){
          Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
          Console.WriteLine("Pregunta 5");
          Console.WriteLine("Deseas utilizar un comodin presiona la letra f");
          Console.WriteLine( "______________________________________________");
          Console.WriteLine("|El albinismo se presenta por la carencia de:?:|");
          Console.WriteLine(" ––––––––––––––––––––––––––––––––––––––––––––––");
          Console.WriteLine("(A)Calcio       (B)Pigmentacion ");
          Console.WriteLine("(C)Vitamina A   (D)Oxigeno");
          opcion=Console.ReadLine();
          } if(opcion=="f" && re>=0){
                        
              Console.WriteLine("A L E R TA");
              Console.WriteLine("Ya no puedes usar comodines");
               Console.WriteLine("Desea Continuar");
              opcion=Console.ReadLine();
          }if(opcion=="si"){
              Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
          Console.WriteLine("Pregunta 5");
          Console.WriteLine(" YA NO HAY COMODINES");
           Console.WriteLine( "______________________________________________");
          Console.WriteLine("|El albinismo se presenta por la carencia de:?:|");
          Console.WriteLine(" ––––––––––––––––––––––––––––––––––––––––––––––");
          Console.WriteLine("(A)Calcio       (B)Pigmentacion ");
          Console.WriteLine("(C)Vitamina A   (D)Oxigeno");
          opcion=Console.ReadLine();
            
          }if(opcion=="B"){
              Console.WriteLine("Opcion correcta");
              Console.WriteLine("Desea Continuar");
              opcion=Console.ReadLine();

          } if(opcion=="f" && re>1){
              comodin=comodin-1;
              re=comodin;
              Console.WriteLine("Haz utilizado un comodin, te quedan:");
              Console.WriteLine(re);
              Console.WriteLine("Respuesta correcta es:(B)Pigmentacion");
              Console.WriteLine("Desea Continuar");
              opcion=Console.ReadLine(); 
                  
              }if (opcion=="si"){
          Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
          Console.WriteLine("Pregunta 6");
          Console.WriteLine("Deseas utilizar un comodin presiona la letra f");
          Console.WriteLine( "______________________________________________");
          Console.WriteLine("|El albinismo se presenta por la carencia de:?:|");
          Console.WriteLine(" ––––––––––––––––––––––––––––––––––––––––––––––");
          Console.WriteLine("(A)Calcio       (B)Pigmentacion ");
          Console.WriteLine("(C)Vitamina A   (D)Oxigeno");
          opcion=Console.ReadLine();
          } if(opcion=="f" && re>=0){
                        
              Console.WriteLine("A L E R TA");
              Console.WriteLine("Ya no puedes usar comodines");
               Console.WriteLine("Desea Continuar");
              opcion=Console.ReadLine();
          }if(opcion=="si"){
              Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
          Console.WriteLine("Pregunta 5");
          Console.WriteLine(" YA NO HAY COMODINES");
           Console.WriteLine( "______________________________________________");
          Console.WriteLine("|El albinismo se presenta por la carencia de:?:|");
          Console.WriteLine(" ––––––––––––––––––––––––––––––––––––––––––––––");
          Console.WriteLine("(A)Calcio       (B)Pigmentacion ");
          Console.WriteLine("(C)Vitamina A   (D)Oxigeno");
          opcion=Console.ReadLine();
            
          }if(opcion=="B"){
              Console.WriteLine("Opcion correcta");
              Console.WriteLine("Desea Continuar");
              opcion=Console.ReadLine();

          } if(opcion=="f" && re>1){
              comodin=comodin-1;
              re=comodin;
              Console.WriteLine("Haz utilizado un comodin, te quedan:");
              Console.WriteLine(re);
              Console.WriteLine("Respuesta correcta es:(B)Pigmentacion");
              Console.WriteLine("Desea Continuar");
              opcion=Console.ReadLine(); 
                  
              }
            
          }
        }
    } 
}