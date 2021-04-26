using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
namespace Quien_Quiere_Ser_Millonario
{
    class Game
    {
        public void ListadePreguntas()
        { 
         Console.Clear();
        Console.BackgroundColor=ConsoleColor.DarkCyan;     

          while(true){
          Console.Clear();
          string opcion="";
          string nombre=""; 
          int comodin=3;
          int re=0;
          
          Console.WriteLine("Escriba su nombre:");
          nombre=Console.ReadLine();
          Console.WriteLine("Las reglas y las instrucciones del juego:");
          Console.WriteLine("1- Lea con atencion las preguntas que apareceran y escriba la opcion correcta de lo contrario perdera el juego");
          Console.WriteLine("2- tienes el derecho de utilizar 3 comodines");
          Console.WriteLine("3- Los comodines eliminan las respuestas incorrectas");
          Console.WriteLine("4- Pon tu teclado en mayuscula");
          Console.WriteLine("5- Tienes derecho a renunciar despues de la primer pregunta con la letra Y");
          Console.WriteLine("6- Tienes derecho a renunciar con la cantidad de premio que obtuvo");
          
          Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX ");
          Console.WriteLine("                                                  EMPECEMOS");
          Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
          Console.WriteLine("\n");
           Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
          Console.WriteLine("                            ___________");
          Console.WriteLine("                           | 1,000,000 |");
          Console.WriteLine("                           |   800,000 |  ");
          Console.WriteLine("                           |   600,000 | ");
          Console.WriteLine("                           |   400,000 |  ");
          Console.WriteLine("                           |   200,000 | ");
          Console.WriteLine("                           |    80,000 | ");
          Console.WriteLine("                           |    65,000 | ");
          Console.WriteLine("                           |    35,000 | ");
          Console.WriteLine("                           |    25,000 | ");
          Console.WriteLine("                           |    15,000 | ");
          Console.WriteLine("                            ––––––––––– ");
          Console.WriteLine("\tPregunta 1  ");
          Console.WriteLine(" POR LPS.15,000");
          Console.WriteLine("Si Deseas utilizar un comodin presiona la letra F  ");
          Console.WriteLine("Deseas renunciar presiona la letra Y");
          Console.WriteLine( "___________________________________");
          Console.WriteLine("|Una tarjeta SD es un dispositivo de|");
          Console.WriteLine(" –––––––––––––––––––––––––––––––––––");
          Console.WriteLine("(A)Procesamiento de Audio (B)Compresion de video ");
          Console.WriteLine("(C)Comunicacion remota    (D)Memoria ");
          opcion=Console.ReadLine();
          re=comodin;
          if(opcion=="Y"){
              Console.WriteLine("HAZ RENUNCIADO");
              Console.WriteLine(nombre);
              Console.WriteLine("NO TIENES PREMIO");
              Console.ReadKey();
              break;
              
          }if(opcion !="D" && opcion!="F"){
              Console.WriteLine("HAZ PERDIDO");
              Console.WriteLine("GRACIAS POR JUGAR");
              Console.WriteLine(nombre);
              Console.ReadKey();
              break;
                                        
            }if(opcion=="D"){
              Console.WriteLine("Opcion correcta");
              Console.WriteLine("Desea Continuar (SI/NO)");
              opcion=Console.ReadLine();
              
          }else if(opcion=="F"){
              comodin=comodin-1;
              re=comodin;

              Console.WriteLine("Haz utilizado un comodin, te quedan:");
              Console.WriteLine(re);
              Console.WriteLine("Respuesta correcta es:(D)Memoria ");
              Console.WriteLine("Desea Continuar (SI/NO)");
              opcion=Console.ReadLine();
              
                                 
            }if(opcion=="NO"){
              Console.WriteLine("TU PREMIO ES LPS 15,000");
              Console.WriteLine("GRACIAS POR JUGAR");
              Console.WriteLine(nombre);
              Console.ReadKey();
              break;
                                        
            }
          if (opcion=="SI"){
           Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
          Console.WriteLine("                            ___________");
          Console.WriteLine("                           | 1,000,000 |");
          Console.WriteLine("                           |   800,000 |  ");
          Console.WriteLine("                           |   600,000 | ");
          Console.WriteLine("                           |   400,000 |  ");
          Console.WriteLine("                           |   200,000 | ");
          Console.WriteLine("                           |    80,000 | ");
          Console.WriteLine("                           |    65,000 | ");
          Console.WriteLine("                           |    35,000 | ");
          Console.WriteLine("                           |    25,000 | ");
          Console.ForegroundColor=ConsoleColor.Red;
          Console.WriteLine("                           |    15,000 | ");
          Console.WriteLine("                            ––––––––––– ");
          Console.ForegroundColor=ConsoleColor.Black;
          Console.WriteLine("\tPregunta 2");
          Console.WriteLine("POR  LPS 25,000");
          Console.WriteLine("Deseas utilizar un comodin presiona la letra F");
          Console.WriteLine("Deseas renunciar presiona la letra Y");
          Console.WriteLine( "_______________________________________________________________________________  ");
          Console.WriteLine("|El sistema electoral para determinar las personas que ocuparan cargos publicos:| ");
          Console.WriteLine(" –––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––  ");
          Console.WriteLine("(A)Sufragio     (B)Adagio ");
          Console.WriteLine("(C)Naufragio    (D)Prestigio ");
          opcion=Console.ReadLine();
            re=comodin;

          }if(opcion=="Y"){
            Console.WriteLine("TU PREMIO ES LPS 15,000");
              Console.WriteLine("GRACIAS POR JUGAR:");
              Console.WriteLine(nombre);
              Console.ReadKey();
              break;
          }if(opcion !="A" && opcion!="F"){
              Console.WriteLine("HAZ PERDIDO");
              Console.WriteLine("GRACIAS POR JUGAR");
              Console.WriteLine(nombre);
              Console.ReadKey();
              break;
                                        
            }if(opcion=="A"){
            Console.WriteLine("Opcion correcta");
              Console.WriteLine("Desea Continuar (SI/NO)");
              opcion=Console.ReadLine();
          }else if(opcion=="F"){
            
              comodin=comodin-1;
              re=comodin;
              Console.WriteLine("Haz utilizado un comodin, te quedan:");
              Console.WriteLine(re);
              Console.WriteLine("Respuesta correcta es:(A)Sufragio");
               Console.WriteLine("Desea Continuar");
              opcion=Console.ReadLine();
                                      
            }  if(opcion=="NO"){
              Console.WriteLine("TU PREMIO ES LPS 25,000");
              Console.WriteLine("GRACIAS POR JUGAR");
              Console.WriteLine(nombre);
              Console.ReadKey();
              break;
                                        
            }if (opcion=="SI"){
          Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
           Console.WriteLine("                           ___________");
          Console.WriteLine("                           | 1,000,000 |");
          Console.WriteLine("                           |   800,000 |  ");
          Console.WriteLine("                           |   600,000 | ");
          Console.WriteLine("                           |   400,000 |  ");
          Console.WriteLine("                           |   200,000 | ");
          Console.WriteLine("                           |    80,000 | ");
          Console.WriteLine("                           |    65,000 | ");
          Console.WriteLine("                           |    35,000 | ");
          Console.ForegroundColor=ConsoleColor.Red;
          Console.WriteLine("                           |    25,000 | ");
          Console.WriteLine("                           |    15,000 | ");
          Console.WriteLine("                            ––––––––––– ");
          Console.ForegroundColor=ConsoleColor.Black;
          Console.WriteLine("\tPregunta 3");
          Console.WriteLine("POR LPS 35,000");
          Console.WriteLine("Deseas utilizar un comodin presiona la letra F");
          Console.WriteLine("Deseas renunciar presiona la letra Y");
          Console.WriteLine( "____________________________________________________________________________");
          Console.WriteLine("|Con que material esculpió Miguel Angel (La Piedad) ubicada en el Vaticano?:|");
          Console.WriteLine(" ––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––");
          Console.WriteLine("(A)Bronce       (B)Marmol ");
          Console.WriteLine("(C)Madera       (D)Yeso ");
          opcion=Console.ReadLine();
           re=comodin;

          }if(opcion=="Y"){
            Console.WriteLine("TU PREMIO ES LPS 25,000");
              Console.WriteLine("GRACIAS POR JUGAR:");
              Console.WriteLine(nombre);
              Console.ReadKey();
              break;
          }if(opcion !="B" && opcion!="F"){
              Console.WriteLine("HAZ PERDIDO");
              Console.WriteLine("GRACIAS POR JUGAR");
              Console.WriteLine(nombre);
              Console.ReadKey();
              break;
                                        
            }if(opcion=="B"){
            Console.WriteLine("Opcion correcta");
              Console.WriteLine("Desea Continuar (SI/NO)");
              opcion=Console.ReadLine();
          }else  if(opcion=="F" && re>=1){
              comodin=comodin-1;
              re=comodin;
              Console.WriteLine("Haz utilizado un comodin, te quedan:");
              Console.WriteLine(re);
              Console.WriteLine("Respuesta correcta es:(B)Marmol");
              Console.WriteLine("Desea Continuar (SI/NO)");
              opcion=Console.ReadLine();            
              
                } if(opcion=="NO"){
              Console.WriteLine("TU PREMIO ES LPS 35,000");
              Console.WriteLine("GRACIAS POR JUGAR");
              Console.WriteLine(nombre);
              Console.ReadKey();
              break;
                                        
            }if (opcion=="SI"){
          Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
           Console.WriteLine("                           ___________");
          Console.WriteLine("                           | 1,000,000 |");
          Console.WriteLine("                           |   800,000 |  ");
          Console.WriteLine("                           |   600,000 | ");
          Console.WriteLine("                           |   400,000 |  ");
          Console.WriteLine("                           |   200,000 | ");
          Console.WriteLine("                           |    80,000 | ");
          Console.WriteLine("                           |    65,000 | ");
          Console.ForegroundColor=ConsoleColor.Red;
          Console.WriteLine("                           |    35,000 | ");
          Console.WriteLine("                           |    25,000 | ");
          Console.WriteLine("                           |    15,000 | ");
          Console.WriteLine("                            ––––––––––– ");
          Console.ForegroundColor=ConsoleColor.Black;
          Console.WriteLine("\tPregunta 4");
          Console.WriteLine("POR 65,000");
          Console.WriteLine("Deseas utilizar un comodin presiona la letra F");
           Console.WriteLine("Deseas renunciar presiona la letra Y");
          Console.WriteLine( "______________________________________");
          Console.WriteLine("|Cual es el idioma oficial de Israel?:|");
          Console.WriteLine(" ––––––––––––––––––––––––––––––––––––––");
          Console.WriteLine("(A)Japones      (B)Griego ");
          Console.WriteLine("(C)Hebreo       (D)Chino ");
          opcion=Console.ReadLine();
           re=comodin;

          }if(opcion=="Y"){
            Console.WriteLine("TU PREMIO ES LPS 35,000");
              Console.WriteLine("GRACIAS POR JUGAR:");
              Console.WriteLine(nombre);
              Console.ReadKey();
              break;
          }if(opcion !="C" && opcion!="F"){
              Console.WriteLine("HAZ PERDIDO");
              Console.WriteLine("GRACIAS POR JUGAR");
              Console.WriteLine(nombre);
              Console.ReadKey();
              break;
                                        
            }else if(opcion=="F" && re<=0){
              Console.WriteLine("A L E R TA");
              Console.WriteLine("Ya no puedes usar comodines");
               Console.WriteLine("Desea Continuar (SI/NO)");
              opcion=Console.ReadLine();
          } if(opcion=="NO"){
              Console.WriteLine("TU PREMIO ES LPS 35,000");
              Console.WriteLine("GRACIAS POR JUGAR");
              Console.WriteLine(nombre);
              Console.ReadKey();
              break;
                                        
            }if(opcion=="SI"){
              Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
          Console.WriteLine("\tPregunta 4");
           Console.WriteLine("Deseas renunciar presiona la letra Y");
          Console.WriteLine(" YA NO HAY COMODINES");
          Console.WriteLine( "______________________________________");
          Console.WriteLine("|Cual es el idioma oficial de Israel?:|");
          Console.WriteLine(" ––––––––––––––––––––––––––––––––––––––");
          Console.WriteLine("(A)Japones      (B)Griego ");
          Console.WriteLine("(C)Hebreo       (D)Chino ");
          opcion=Console.ReadLine();
            
          }if(opcion=="Y"){
            Console.WriteLine("TU PREMIO ES LPS 35,000");
              Console.WriteLine("GRACIAS POR JUGAR:");
              Console.WriteLine(nombre);
              Console.ReadKey();
              break;
          }if(opcion !="C" && opcion!="F" ){
              Console.WriteLine("HAZ PERDIDO");
              Console.WriteLine("GRACIAS POR JUGAR");
              Console.WriteLine(nombre);
              Console.ReadKey();
              break;
                                        
            }if(opcion=="C"){
              Console.WriteLine("Opcion correcta");
              Console.WriteLine("Desea Continuar (SI/NO)");
              opcion=Console.ReadLine();

          }if(opcion=="F" && re>=1){
              comodin=comodin-1;
              re=comodin;
              Console.WriteLine("Haz utilizado un comodin, te quedan:");
              Console.WriteLine(re);
              Console.WriteLine("Respuesta correcta es:(C)Hebreo");
              Console.WriteLine("Desea Continuar (SI/NO)");
              opcion=Console.ReadLine(); 
                  
              }if(opcion=="NO"){
              Console.WriteLine("TU PREMIO ES LPS 65,000");
              Console.WriteLine("GRACIAS POR JUGAR");
              Console.WriteLine(nombre);
              Console.ReadKey();
              break;
                                        
            }if (opcion=="SI"){
          Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
           Console.WriteLine("                           ___________");
          Console.WriteLine("                           | 1,000,000 |");
          Console.WriteLine("                           |   800,000 |  ");
          Console.WriteLine("                           |   600,000 | ");
          Console.WriteLine("                           |   400,000 |  ");
          Console.WriteLine("                           |   200,000 | ");
          Console.WriteLine("                           |    80,000 | ");
           Console.ForegroundColor=ConsoleColor.Red;
          Console.WriteLine("                           |    65,000 | ");
          Console.WriteLine("                           |    35,000 | ");
          Console.WriteLine("                           |    25,000 | ");
          Console.WriteLine("                           |    15,000 | ");
          Console.WriteLine("                            ––––––––––– ");
          Console.ForegroundColor=ConsoleColor.Black;
          Console.WriteLine("/t Pregunta 5");
          Console.WriteLine("POR 80,000");
          Console.WriteLine("Deseas utilizar un comodin presiona la letra F");
          Console.WriteLine("Deseas renunciar presiona la letra Y");
          Console.WriteLine( "______________________________________________");
          Console.WriteLine("|El albinismo se presenta por la carencia de:?:|");
          Console.WriteLine(" ––––––––––––––––––––––––––––––––––––––––––––––");
          Console.WriteLine("(A)Calcio       (B)Pigmentacion ");
          Console.WriteLine("(C)Vitamina A   (D)Oxigeno");
          opcion=Console.ReadLine();
           re=comodin;

          }if(opcion=="Y"){
            Console.WriteLine("TU PREMIO ES LPS 65,000");
              Console.WriteLine("GRACIAS POR JUGAR:");
              Console.WriteLine(nombre);
              Console.ReadKey();
              break;
          } if(opcion !="B" && opcion!="F"){
              Console.WriteLine("HAZ PERDIDO");
              Console.WriteLine("GRACIAS POR JUGAR");
              Console.WriteLine(nombre);
              Console.ReadKey();
              break;
                                        
            }if(opcion=="F" && re<=0){
                        
              Console.WriteLine("A L E R TA");
              Console.WriteLine("Ya no puedes usar comodines");
               Console.WriteLine("Desea Continuar (SI/NO)");
              opcion=Console.ReadLine();
          }if(opcion=="NO"){
              Console.WriteLine("TU PREMIO ES LPS 65,000");
              Console.WriteLine("GRACIAS POR JUGAR");
              Console.WriteLine(nombre);
              Console.ReadKey();
              break;
                                        
            }if(opcion=="SI"){
              Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
          Console.WriteLine("\tPregunta 5");
          Console.WriteLine(" YA NO HAY COMODINES");
            Console.WriteLine("Deseas renunciar presiona la letra Y");
           Console.WriteLine( "______________________________________________");
          Console.WriteLine("|El albinismo se presenta por la carencia de   |");
          Console.WriteLine(" ––––––––––––––––––––––––––––––––––––––––––––––");
          Console.WriteLine("(A)Calcio       (B)Pigmentacion ");
          Console.WriteLine("(C)Vitamina A   (D)Oxigeno");
          opcion=Console.ReadLine();
            
          }if(opcion=="Y"){
            Console.WriteLine("TU PREMIO ES LPS 65,000");
              Console.WriteLine("GRACIAS POR JUGAR:");
              Console.WriteLine(nombre);
              Console.ReadKey();
              break;
          }if(opcion !="B" && opcion!="F"){
              Console.WriteLine("HAZ PERDIDO");
              Console.WriteLine("GRACIAS POR JUGAR");
              Console.WriteLine(nombre);
              Console.ReadKey();
              break;
                                        
            }if(opcion=="B"){
              Console.WriteLine("Opcion correcta");
              Console.WriteLine("Desea Continuar (SI/NO)");
              opcion=Console.ReadLine();

          } if(opcion=="F" && re>=1){
              comodin=comodin-1;
              re=comodin;
              Console.WriteLine("Haz utilizado un comodin, te quedan:");
              Console.WriteLine(re);
              Console.WriteLine("Respuesta correcta es:(B)Pigmentacion");
              Console.WriteLine("Desea Continuar (SI/NO)");
              opcion=Console.ReadLine(); 
                  
              }if(opcion=="NO"){
              Console.WriteLine("TU PREMIO ES LPS 80,000");
              Console.WriteLine("GRACIAS POR JUGAR");
              Console.ReadKey();
              break;
                                        
            }if (opcion=="SI"){
          Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
          Console.WriteLine("                           ___________");
          Console.WriteLine("                           | 1,000,000 |");
          Console.WriteLine("                           |   800,000 |  ");
          Console.WriteLine("                           |   600,000 | ");
          Console.WriteLine("                           |   400,000 |  ");
          Console.WriteLine("                           |   200,000 | ");
          Console.ForegroundColor=ConsoleColor.Red;
          Console.WriteLine("                           |    80,000 | ");
          Console.WriteLine("                           |    65,000 | ");
          Console.WriteLine("                           |    35,000 | ");
          Console.WriteLine("                           |    25,000 | ");
          Console.WriteLine("                           |    15,000 | ");
          Console.WriteLine("                            ––––––––––– ");
          Console.ForegroundColor=ConsoleColor.Black;

          Console.WriteLine("\t Pregunta 6");
          Console.WriteLine("POR LPS 200,000");
          Console.WriteLine("Deseas utilizar un comodin presiona la letra F");
            Console.WriteLine("Deseas renunciar presiona la letra Y");
         Console.WriteLine( "____________________");
          Console.WriteLine("|La hormiga es un:  ?|");
          Console.WriteLine(" ––––––––––––––––––––");
          Console.WriteLine("(A)Insecto            (B)Mamifero ");
          Console.WriteLine("(C)Reptil             (D)Aracnido");
          opcion=Console.ReadLine();
          re=comodin;

          }if(opcion=="Y"){
            Console.WriteLine("TU PREMIO ES LPS 80,000");
              Console.WriteLine("GRACIAS POR JUGAR:");
              Console.WriteLine(nombre);
              Console.ReadKey();
              break;
          }if(opcion !="A" && opcion!="F"){
              Console.WriteLine("HAZ PERDIDO");
              Console.WriteLine("GRACIAS POR JUGAR");
              Console.WriteLine(nombre);
              Console.ReadKey();
              break;
                                        
            } if(opcion=="F" && re<=0){
                        
              Console.WriteLine("A L E R TA");
              Console.WriteLine("Ya no puedes usar comodines");
               Console.WriteLine("Desea Continuar (SI/NO)");
              opcion=Console.ReadLine();
          }if(opcion=="NO"){
              Console.WriteLine("TU PREMIO ES LPS 80,000");
              Console.WriteLine("GRACIAS POR JUGAR");
              Console.WriteLine(nombre);
              Console.ReadKey();
              break;
                                        
            }if(opcion=="SI"){
              Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
          Console.WriteLine("\tPregunta 6");
          Console.WriteLine(" YA NO HAY COMODINES");
            Console.WriteLine("Deseas renunciar presiona la letra Y");
           Console.WriteLine( "____________________");
          Console.WriteLine("|La hormiga es un:  ?|");
          Console.WriteLine(" ––––––––––––––––––––");
          Console.WriteLine("(A)Insecto            (B)Mamifero ");
          Console.WriteLine("(C)Reptil             (D)Aracnido");
          opcion=Console.ReadLine();
            
          }if(opcion=="Y"){
            Console.WriteLine("TU PREMIO ES LPS 80,000");
              Console.WriteLine("GRACIAS POR JUGAR:");
              Console.WriteLine(nombre);
              Console.ReadKey();
              break;
          }if(opcion !="A" && opcion!="F"){
              Console.WriteLine("HAZ PERDIDO");
              Console.WriteLine("GRACIAS POR JUGAR");
              Console.WriteLine(nombre);
              Console.ReadKey();
              break;
                                        
            }if(opcion=="A"){
              Console.WriteLine("Opcion correcta");
              Console.WriteLine("Desea Continuar (SI/NO)");
              opcion=Console.ReadLine();

          } if(opcion=="F" && re>=1){
              comodin=comodin-1;
              re=comodin;
              Console.WriteLine("Haz utilizado un comodin, te quedan:");
              Console.WriteLine(re);
              Console.WriteLine("Respuesta correcta es:(A)Insecto");
              Console.WriteLine("Desea Continuar (SI/NO)");
              opcion=Console.ReadLine(); 
                  
              }if(opcion=="NO"){
              Console.WriteLine("TU PREMIO ES LPS 200,000");
              Console.WriteLine("GRACIAS POR JUGAR");
              Console.ReadKey();
              break;
                                        
            }if (opcion=="SI"){
          Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
           Console.WriteLine("                           ___________");
          Console.WriteLine("                           | 1,000,000 |");
          Console.WriteLine("                           |   800,000 |  ");
          Console.WriteLine("                           |   600,000 | ");
          Console.WriteLine("                           |   400,000 |  ");
          Console.ForegroundColor=ConsoleColor.Red;
          Console.WriteLine("                           |   200,000 | ");
          Console.WriteLine("                           |    80,000 | ");
          Console.WriteLine("                           |    65,000 | ");
          Console.WriteLine("                           |    35,000 | ");
          Console.WriteLine("                           |    25,000 | ");
          Console.WriteLine("                           |    15,000 | ");
          Console.WriteLine("                            ––––––––––– ");
          Console.ForegroundColor=ConsoleColor.Black;
          Console.WriteLine("\tPregunta 7");
          Console.WriteLine("POR LPS 400,000");
          Console.WriteLine("Deseas utilizar un comodin presiona la letra F");
          Console.WriteLine("Deseas renunciar presiona la letra Y");
          Console.WriteLine( "_________________________________________________________");
          Console.WriteLine("|A que tipo de animales se refiere la palabra (aviario)  ?|");
          Console.WriteLine(" –––––––––––––––––––––––––––––––––––––––––––––––––––––––––");
          Console.WriteLine("(A)Peces             (B)Moluscos ");
          Console.WriteLine("(C)Mamiferos         (D)Aves");
          opcion=Console.ReadLine();
          re=comodin;

          }if(opcion=="Y"){
            Console.WriteLine("TU PREMIO ES LPS 200,000");
              Console.WriteLine("GRACIAS POR JUGAR:");
              Console.WriteLine(nombre);
              Console.ReadKey();
              break;
          }if(opcion !="D" && opcion!="F"){
              Console.WriteLine("HAZ PERDIDO");
              Console.WriteLine("GRACIAS POR JUGAR");
              Console.WriteLine(nombre);
              Console.ReadKey();
              break;
                                        
            } if(opcion=="F" && re<=0){
                        
              Console.WriteLine("A L E R TA");
              Console.WriteLine("Ya no puedes usar comodines");
               Console.WriteLine("Desea Continuar (SI/NO)");
              opcion=Console.ReadLine();
          }if(opcion=="NO"){
              Console.WriteLine("TU PREMIO ES LPS 200,000");
              Console.WriteLine("GRACIAS POR JUGAR");
              Console.WriteLine(nombre);
              Console.ReadKey();
              break;
                                        
            }if(opcion=="SI"){
              Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
          Console.WriteLine("Pregunta 7");
          Console.WriteLine(" YA NO HAY COMODINES");
          Console.WriteLine(" Desea renunciar presiona la letra Y");
         Console.WriteLine( " _________________________________________________________");
          Console.WriteLine("|A que tipo de animales se refiere la palabra (aviario)  ?|");
          Console.WriteLine(" –––––––––––––––––––––––––––––––––––––––––––––––––––––––––");
          Console.WriteLine("(A)Peces             (B)Moluscos ");
          Console.WriteLine("(C)Mamiferos         (D)Aves");
          opcion=Console.ReadLine();
            
          }if(opcion=="Y"){
            Console.WriteLine("TU PREMIO ES LPS 200,000");
              Console.WriteLine("GRACIAS POR JUGAR:");
              Console.WriteLine(nombre);
              Console.ReadKey();
              break;
          }if(opcion !="D" && opcion!="F"){
              Console.WriteLine("HAZ PERDIDO");
              Console.WriteLine("GRACIAS POR JUGAR");
              Console.WriteLine(nombre);
              Console.ReadKey();
              break;
                                        
            }if(opcion=="D"){
              Console.WriteLine("Opcion correcta");
              Console.WriteLine("Desea Continuar (SI/NO)");
              opcion=Console.ReadLine();

          } if(opcion=="F" && re>=1){
              comodin=comodin-1;
              re=comodin;
              Console.WriteLine("Haz utilizado un comodin, te quedan:");
              Console.WriteLine(re);
              Console.WriteLine("Respuesta correcta es:(D)Aves");
              Console.WriteLine("Desea Continuar (SI/NO)");
              opcion=Console.ReadLine(); 
                  
              }if(opcion=="NO"){
              Console.WriteLine("TU PREMIO ES LPS 400,000");
              Console.WriteLine("GRACIAS POR JUGAR");
              Console.ReadKey();
              break;
                                        
            }if (opcion=="SI"){
          Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
           Console.WriteLine("                           ___________");
          Console.WriteLine("                           | 1,000,000 |");
          Console.WriteLine("                           |   800,000 |  ");
          Console.WriteLine("                           |   600,000 | ");
          Console.ForegroundColor=ConsoleColor.Red;
          Console.WriteLine("                           |   400,000 |  ");
          Console.WriteLine("                           |   200,000 | ");
          Console.WriteLine("                           |    80,000 | ");
          Console.WriteLine("                           |    65,000 | ");
          Console.WriteLine("                           |    35,000 | ");
          Console.WriteLine("                           |    25,000 | ");
          Console.WriteLine("                           |    15,000 | ");
          Console.WriteLine("                            ––––––––––– ");
          Console.ForegroundColor=ConsoleColor.Black;
          Console.WriteLine("Pregunta 8");
          Console.WriteLine("POR LPS 600,000");
          Console.WriteLine("Deseas utilizar un comodin presiona la letra F");
          Console.WriteLine("Deseas renunciar presiona la letra Y");
          Console.WriteLine( " _________________________________________________");
          Console.WriteLine("|Es el oso blanco que habita en el hielo artico  ?|");
          Console.WriteLine(" –––––––––––––––––––––––––––––––––––––––––––––––––");
          Console.WriteLine("(A)Tropical            (B)Oriental ");
          Console.WriteLine("(C)Polar               (D)Montañes");
          opcion=Console.ReadLine();
           re=comodin;

          }if(opcion=="Y"){
            Console.WriteLine("TU PREMIO ES LPS 400,000");
              Console.WriteLine("GRACIAS POR JUGAR:");
              Console.WriteLine(nombre);
              Console.ReadKey();
              break;
          } if(opcion !="C" && opcion!="F"){
              Console.WriteLine("HAZ PERDIDO");
              Console.WriteLine("GRACIAS POR JUGAR");
              Console.WriteLine(nombre);
              Console.ReadKey();
              break;
                                        
            }if(opcion=="F" && re<=0){
                        
              Console.WriteLine("A L E R TA");
              Console.WriteLine("Ya no puedes usar comodines");
               Console.WriteLine("Desea Continuar (SI/NO)");
              opcion=Console.ReadLine();
          }if(opcion=="NO"){
              Console.WriteLine("TU PREMIO ES LPS 400,000");
              Console.WriteLine("GRACIAS POR JUGAR");
              Console.ReadKey();
              break;
                                        
            }if(opcion=="SI"){
              Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
          Console.WriteLine("\tPregunta 8");
          Console.WriteLine(" YA NO HAY COMODINES");
         Console.WriteLine( " _________________________________________________");
          Console.WriteLine("|Es el oso blanco que habita en el hielo artico  ?|");
          Console.WriteLine(" –––––––––––––––––––––––––––––––––––––––––––––––––");
          Console.WriteLine("(A)Tropical            (B)Oriental ");
          Console.WriteLine("(C)Polar               (D)Montañes");
          opcion=Console.ReadLine();
            
          }if(opcion=="Y"){
              Console.WriteLine("TU PREMIO ES LPS 400,000");
              Console.WriteLine("GRACIAS POR JUGAR");
              Console.WriteLine(nombre);
              Console.ReadKey();
              break;
                                        
            }if(opcion !="C" && opcion!="F"){
              Console.WriteLine("HAZ PERDIDO");
              Console.WriteLine("GRACIAS POR JUGAR");
              Console.WriteLine(nombre);
              Console.ReadKey();
              break;
                                        
            } if(opcion=="F" && re>=1){
              comodin=comodin-1;
              re=comodin;
              Console.WriteLine("Haz utilizado un comodin, te quedan:");
              Console.WriteLine(re);
              Console.WriteLine("Respuesta correcta es:(C)Polar");
              Console.WriteLine("Desea Continuar (SI/NO)");
              opcion=Console.ReadLine(); 
                  
              }if(opcion=="C"){
              Console.WriteLine("Opcion correcta");
              Console.WriteLine("Desea Continuar (SI/NO)");
              opcion=Console.ReadLine();

           }  if(opcion=="NO"){
              Console.WriteLine("TU PREMIO ES LPS 600,000");
              Console.WriteLine("GRACIAS POR JUGAR");
              Console.WriteLine(nombre);
              Console.ReadKey();
              break;
                                        
            }if (opcion=="SI"){
          Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
           Console.WriteLine("                           ___________");
          Console.WriteLine("                           | 1,000,000 |");
          Console.WriteLine("                           |   800,000 |  ");
          Console.ForegroundColor=ConsoleColor.Red;
          Console.WriteLine("                           |   600,000 | ");
          Console.WriteLine("                           |   400,000 |  ");
          Console.WriteLine("                           |   200,000 | ");
          Console.WriteLine("                           |    80,000 | ");
          Console.WriteLine("                           |    65,000 | ");
          Console.WriteLine("                           |    35,000 | ");
          Console.WriteLine("                           |    25,000 | ");
          Console.WriteLine("                           |    15,000 | ");
          Console.WriteLine("                            ––––––––––– ");
          Console.ForegroundColor=ConsoleColor.Black;
          Console.WriteLine("\tPregunta 9");
          Console.WriteLine("POR LPS 800,000");
         Console.WriteLine("Deseas utilizar un comodin presiona la letra F");
           Console.WriteLine("Deseas renunciar presiona la letra Y");
          Console.WriteLine( " _______________________________________________________");
          Console.WriteLine("|Que elemento químico es representado por el símbolo P  ?|");
          Console.WriteLine(" ––––––––––––––––––––––––––––––––––––––––––––––––––––––––");
          Console.WriteLine("(A)Fosforo             (B)Boro ");
          Console.WriteLine("(C)Bromo               (D)Rubidio");
          opcion=Console.ReadLine();
            re=comodin;

          }if(opcion=="Y"){
              Console.WriteLine("TU PREMIO ES LPS 600,000");
              Console.WriteLine("GRACIAS POR JUGAR");
              Console.WriteLine(nombre);
              Console.ReadKey();
              break;
                                        
            } if(opcion !="A" && opcion!="F"){
              Console.WriteLine("HAZ PERDIDO");
              Console.WriteLine("GRACIAS POR JUGAR");
              Console.WriteLine(nombre);
              Console.ReadKey();
              break;
                                        
            }if(opcion=="F" && re<=0){
                        
              Console.WriteLine("A L E R TA");
              Console.WriteLine("Ya no puedes usar comodines");
               Console.WriteLine("Desea Continuar(SI/NO)");
              opcion=Console.ReadLine();
          }if(opcion=="NO"){
              Console.WriteLine("TU PREMIO ES LPS 600,000");
              Console.WriteLine("GRACIAS POR JUGAR");
              Console.WriteLine(nombre);
              Console.ReadKey();
              break;
                                        
            }if(opcion=="SI"){
              Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
          Console.WriteLine("\tPregunta 9");
          Console.WriteLine(" YA NO HAY COMODINES");
          Console.WriteLine("Deseas renunciar presiona la letra Y");
          Console.WriteLine( " _______________________________________________________");
          Console.WriteLine("|Que elemento químico es representado por el símbolo P  ?|");
          Console.WriteLine(" ––––––––––––––––––––––––––––––––––––––––––––––––––––––––");
          Console.WriteLine("(A)Fosforo             (B)Boro ");
          Console.WriteLine("(C)Bromo               (D)Rubidio");
          opcion=Console.ReadLine();
            
          }if(opcion=="Y"){
              Console.WriteLine("TU PREMIO ES LPS 600,000");
              Console.WriteLine("GRACIAS POR JUGAR");
              Console.WriteLine(nombre);
              Console.ReadKey();
              break;
                                        
            }if(opcion !="A" && opcion!="F"){
              Console.WriteLine("HAZ PERDIDO");
              Console.WriteLine("GRACIAS POR JUGAR");
              Console.WriteLine(nombre);
              Console.ReadKey();
              break;
                                        
            }if(opcion=="A"){
              Console.WriteLine("Opcion correcta");
              Console.WriteLine("Desea Continuar (SI/NO)");
              opcion=Console.ReadLine();

          } if(opcion=="F" && re>=1){
              comodin=comodin-1;
              re=comodin;
              Console.WriteLine("Haz utilizado un comodin, te quedan:");
              Console.WriteLine(re);
              Console.WriteLine("Respuesta correcta es:(A)Fosforo");
              Console.WriteLine("Desea Continuar (SI/NO)");
              opcion=Console.ReadLine(); 
                  
              }if(opcion=="NO"){
              Console.WriteLine("TU PREMIO ES LPS 800,000");
              Console.WriteLine("GRACIAS POR JUGAR");
              Console.WriteLine(nombre);
              Console.ReadKey();
              break;
                                        
            }if (opcion=="SI"){
          Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
          Console.WriteLine("                            ___________");
          Console.WriteLine("                           | 1,000,000 |");
          Console.ForegroundColor=ConsoleColor.Red;
          Console.WriteLine("                           |   800,000 |  ");
          Console.WriteLine("                           |   600,000 | ");
          Console.WriteLine("                           |   400,000 |  ");
          Console.WriteLine("                           |   200,000 | ");
          Console.WriteLine("                           |    80,000 | ");
          Console.WriteLine("                           |    65,000 | ");
          Console.WriteLine("                           |    35,000 | ");
          Console.WriteLine("                           |    25,000 | ");
          Console.WriteLine("                           |    15,000 | ");
          Console.WriteLine("                            ––––––––––– ");
          Console.ForegroundColor=ConsoleColor.Black;
          Console.WriteLine("\tPregunta 10");
          Console.WriteLine("POR LPS 1,000,000");
          Console.WriteLine("Deseas utilizar un comodin presiona la letra F");
          Console.WriteLine("Deseas renunciar presiona la letra Y");
          Console.WriteLine( " _______________________________________________________");
          Console.WriteLine("|Cual de las siguientes palabras es una preposición     ?|");
          Console.WriteLine(" ––––––––––––––––––––––––––––––––––––––––––––––––––––––––");
          Console.WriteLine("(A)La            (B)De ");
          Console.WriteLine("(C)Ser           (D)Una");
          opcion=Console.ReadLine();
                     re=comodin;

          }if(opcion=="Y"){
              Console.WriteLine("TU PREMIO ES LPS 800,000");
              Console.WriteLine("GRACIAS POR JUGAR");
              Console.WriteLine(nombre);
              Console.ReadKey();
              break;
                                        
            } if(opcion !="B" && opcion!="F"){
              Console.WriteLine("HAZ PERDIDO");
              Console.WriteLine("GRACIAS POR JUGAR");
              Console.WriteLine(nombre);
              Console.ReadKey();
              break;
                                        
            }if(opcion=="F" && re<=0){
                        
              Console.WriteLine("A L E R TA");
              Console.WriteLine("Ya no puedes usar comodines");
               Console.WriteLine("Desea Continuar (SI/NO)");
              opcion=Console.ReadLine();
          }if(opcion=="NO"){
              Console.WriteLine("TU PREMIO ES LPS 800,000");
              Console.WriteLine("GRACIAS POR JUGAR");
              Console.ReadKey();
              break;
                                        
            }if(opcion=="SI"){
              Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
          Console.WriteLine("Pregunta 10");
          Console.WriteLine(" YA NO HAY COMODINES");
           Console.WriteLine("Deseas renunciar presiona la letra Y");
          Console.WriteLine( " _______________________________________________________");
          Console.WriteLine("|Cual de las siguientes palabras es una preposición     ?|");
          Console.WriteLine(" ––––––––––––––––––––––––––––––––––––––––––––––––––––––––");
          Console.WriteLine("(A)La            (B)De ");
          Console.WriteLine("(C)Ser           (D)Una");
          opcion=Console.ReadLine();
            
          }if(opcion=="Y"){
              Console.WriteLine("TU PREMIO ES LPS 800,000");
              Console.WriteLine("GRACIAS POR JUGAR");
              Console.WriteLine(nombre);
              Console.ReadKey();
              break;
                                        
            }if(opcion !="B" && opcion!="F"){
              Console.WriteLine("HAZ PERDIDO");
              Console.WriteLine("GRACIAS POR JUGAR");
              Console.WriteLine(nombre);
              Console.ReadKey();
              break;
                                        
            }if(opcion=="B"){
              Console.WriteLine("Opcion correcta");
              opcion=Console.ReadLine();
              Console.ForegroundColor=ConsoleColor.Red;

          Console.WriteLine("    GANASTES ERES MILLONARIO");
          Console.WriteLine("                            ___________");
          Console.WriteLine("                           | 1,000,000 |");
          Console.WriteLine("                           |   800,000 |  ");
          Console.WriteLine("                           |   600,000 | ");
          Console.WriteLine("                           |   400,000 |  ");
          Console.WriteLine("                           |   200,000 | ");
          Console.WriteLine("                           |    80,000 | ");
          Console.WriteLine("                           |    65,000 | ");
          Console.WriteLine("                           |    35,000 | ");
          Console.WriteLine("                           |    25,000 | ");
          Console.WriteLine("                           |    15,000 | ");
          Console.WriteLine("                            ––––––––––– ");
              Console.ReadKey();
              break;

          } if(opcion=="F" && re>=1){
              comodin=comodin-1;
              re=comodin;
              Console.WriteLine("Haz utilizado un comodin, te quedan:");
              Console.WriteLine(re);
              Console.WriteLine("Respuesta correcta es:(B)De");
             
              opcion=Console.ReadLine(); 
          Console.ForegroundColor=ConsoleColor.Red;
          Console.WriteLine("    GANASTES ERES MILLONARIO");
          Console.WriteLine("                            ___________");
          Console.WriteLine("                           | 1,000,000 |");
          Console.WriteLine("                           |   800,000 |  ");
          Console.WriteLine("                           |   600,000 | ");
          Console.WriteLine("                           |   400,000 |  ");
          Console.WriteLine("                           |   200,000 | ");
          Console.WriteLine("                           |    80,000 | ");
          Console.WriteLine("                           |    65,000 | ");
          Console.WriteLine("                           |    35,000 | ");
          Console.WriteLine("                           |    25,000 | ");
          Console.WriteLine("                           |    15,000 | ");
          Console.WriteLine("                            ––––––––––– ");
          Console.ForegroundColor=ConsoleColor.Black;
             Console.ReadKey();
              break;

              }
            
          }
        }
    } 
}