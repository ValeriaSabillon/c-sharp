using System;
using System.Collections.Generic;  
namespace Animales
{   
    class TiposDeAnimales
    {
    
    public List<Perro> ListaDePerros { get; set; }
    public List<Gato> ListaDeGatos { get; set; }
    public List<Leon> ListaDeLeon { get; set; }
    public List<Loro> ListaDeLoro{ get; set; }
    public List<Aguila> ListaDeAguila{ get; set; }
    public List<PezGlobo> ListaDePezGlobo { get; set; }
    public List<Delfin> ListaDeDelfin { get; set; }
    

    public TiposDeAnimales()
    {
        ListaDePerros =new List<Perro>();
        perro();
     
        ListaDeGatos = new List<Gato>();
        gato();

        ListaDeLeon = new List<Leon>();
        leon();

        ListaDeLoro = new List<Loro>();
        loro();

        ListaDeAguila = new List<Aguila>();
        aguila();

        ListaDePezGlobo = new List<PezGlobo>();
        pezglobo();

        ListaDeDelfin = new List<Delfin>();
        delfin();
       


    }

    private void perro()
    {
        Perro a = new Perro ("Brandy","7","Hembra","4","Viviparos","Rottwailer",true,true);
        ListaDePerros.Add(a);
        Perro b = new Perro ("Thor","5","Macho","4","Viviparos","Pasto Aleman",true,true);
        ListaDePerros.Add(b);
        Perro c = new Perro ("Zeus","10","Macho","4","Viviparos","Pitbull",true,true);
        ListaDePerros.Add(c);
        
    }
    private void gato()
    {
        Gato a = new Gato ("Katy","6","Hembra","4","Viviparos","Con Pelo",true,true);
        ListaDeGatos.Add(a);
        Gato b = new Gato ("Bola De Nieve","7","Macho","4","Viviparos","Sin Pelo",true,true);
        ListaDeGatos.Add(b);
        Gato c = new Gato ("Pelusa","5","Hembra","4","Viviparos","Con Pelo",true,true);
        ListaDeGatos.Add(c);
        Gato d = new Gato ("Tom","10","Macho","4","Viviparos","Con Pelo",true,true);
        ListaDeGatos.Add(c);
    }
    private void leon()
    {
        Leon a = new Leon ("Zimba","4","Macho","4","Viviparos",true,true);
        ListaDeLeon.Add(a);
        Leon b = new Leon ("Nala","3","Hembra","4","Viviparos",true,true);
        ListaDeLeon.Add(b);
        Leon c = new Leon ("Scar","5","Macho","4","Viviparos",true,true);
        ListaDeLeon.Add(c);
        Leon d = new Leon ("Mufasa","9","Macho","4","Viviparos",true,true);
        ListaDeLeon.Add(d);
    }
    private void loro()
    {
        Loro a = new Loro ("Paquito","1","Macho","verde",true,true);
        ListaDeLoro.Add(a);
        Loro b = new Loro ("Plumita","2","Hembra","rojo y verde",true,true);
        ListaDeLoro.Add(b);
        Loro c = new Loro ("Piolin","5","Hembra"," verde",true,true);
        ListaDeLoro.Add(c);
        Loro d = new Loro ("Aquiles","5","Macho"," amarillo y verde",true,true);
        ListaDeLoro.Add(d);
    }
     private void aguila()
    {
        Aguila a = new Aguila ("Aguila calva ","9","Hembra","blanca y cafe",true,true);
        ListaDeAguila.Add(a);
        Aguila b = new Aguila("Aguila coronada","Macho","14","cafe",true,true);
        ListaDeAguila.Add(b);
        Aguila c = new Aguila("Halcon","Macho","2","gris",true,true);
        ListaDeAguila.Add(c);
    }
     private void pezglobo()
    {
        PezGlobo a = new PezGlobo ("Nemo ","1","Macho","1",true,true);
        ListaDePezGlobo.Add(a);
        PezGlobo b = new PezGlobo("Dori","3","Hembra","2",true,true);
        ListaDePezGlobo.Add(b);
        PezGlobo c = new PezGlobo("Marlin","6","Macho","2",true,true);
        ListaDePezGlobo.Add(c);
    }
     private void delfin()
    {
        Delfin a = new Delfin ("Caramelo","20","Macho","3",true,true);
        ListaDeDelfin.Add(a);
        Delfin b = new Delfin("Duque","7","Macho","3",true,true);
        ListaDeDelfin.Add(b);
        Delfin c = new Delfin("Copito","10","Macho","3",true,true);
        ListaDeDelfin.Add(c);
        Delfin d = new Delfin("Winter","13","Hembra","3",true,true);
        ListaDeDelfin.Add(d);
    }
    
    public void ListaMamiferos()
    {
        while (true){
        Console.Clear();
        string op="";
        Console.WriteLine("\tLISTA DE MAMIFEROS");
        Console.WriteLine("\tXXXXXXXXXXXXXXXXXX");
        Console.WriteLine("Si Desea ver lista de perro PRESIONE (p) --si desea ver lista de gatos PRESIONE (g) ");
        Console.WriteLine("Si desea ver lista de leones PRESIONE (l), si desea SALIR PRESIONE (0)");
        op=Console.ReadLine();
        if(op=="p"){
        Console.Clear();
        Console.WriteLine("\tHAZ ELIGIDO PERROS");
        Console.WriteLine("\tXXXXXXXXXXXXXXXX");
        Console.WriteLine("NOMBRE|EDAD|SEXO|NUMERO DE PATAS|TIPO DE REPRODUCCION|RAZA|COMER|LADRAR");
        
        foreach (var perros in ListaDePerros)
        {
            Console.WriteLine(perros.Nombre+" | "+perros.Edad+" | "+perros.Sexo+" | "+perros.Patas+" | "+perros.Reproduccion+" | "+perros.Raza+" | "+perros.Comer+" | "+perros.Ladrar);
        }
        Console.ReadLine();
        }else if(op=="g"){
        Console.Clear();
        Console.WriteLine("\tHAZ ELEGIDO GATOS");
        Console.WriteLine("\tXXXXXXXXXXXXXXXX");
        Console.WriteLine("NOMBRE|EDAD|SEXO|NUMERO DE PATAS|TIPO DE REPRODUCCION|TIPO DE PELAJE|COMER|MAULLAR");
         foreach (var gatos in ListaDeGatos)
        {
            Console.WriteLine(gatos.Nombre+" | "+gatos.Edad+" | "+gatos.Sexo+" | "+gatos.Patas+" | "+gatos.Reproduccion+" | "+gatos.Pelaje+" | "+ gatos.Comer+" | "+gatos.Maullar);
        }
        Console.ReadLine();   
        }else if(op=="l"){
        Console.Clear();
        Console.WriteLine("\tHAZ ELEGIDO LEONES");
        Console.WriteLine("\tXXXXXXXXXXXXXXXX");
        Console.WriteLine("NOMBRE|EDAD|SEXO|NUMERO DE PATAS|TIPO DE REPRODUCCION|COMER|RUGIR");
         foreach (var leones in ListaDeLeon)
        {
            Console.WriteLine(leones.Nombre+" | "+leones.Edad+" | "+leones.Sexo+" | "+leones.Patas+" | "+leones.Reproduccion+" | "+ leones.Comer+" | "+leones.Rugir);
        }
        Console.ReadLine();   
        }else if (op=="0"){
            break;
              }
          }
        }
        public void  ListaAves()
        {
        while (true){
        Console.Clear();
        string op="";
        Console.WriteLine("\tLISTA DE AVES");
        Console.WriteLine("\tXXXXXXXXXXXXX");
        Console.WriteLine("Si Desea ver lista de loros PRESIONE (l) --si desea ver lista de aguilas PRESIONE (a) si desea SALIR PRESIONE (0)");
        op=Console.ReadLine();
        if(op=="l"){
        Console.Clear();
        Console.WriteLine("\tHAZ ELIGIDO LOROS");
        Console.WriteLine("\tXXXXXXXXXXXXXXXX");
        Console.WriteLine("NOMBRE|EDAD|SEXO|PLUMAJE|COMER|HABLAR");
        
        foreach (var loros in ListaDeLoro)
        {
            Console.WriteLine(loros.Nombre+" | "+loros.Edad+" | "+loros.Sexo+" | "+loros.ColorPlumaje+" | "+loros.Comer+" | "+loros.Hablar);
        }
        Console.ReadLine();
        }else if(op=="a"){
        Console.Clear();
        Console.WriteLine("\tHAZ ELEGIDO AGUILAS");
        Console.WriteLine("\tXXXXXXXXXXXXXXXX");
        Console.WriteLine("NOMBRE|EDAD|SEXO|COLOR PLUMAJE|VUELO ALTO");
         foreach (var aguilas in ListaDeAguila)
        {
            Console.WriteLine(aguilas.Nombre+" | "+aguilas.Edad+" | "+aguilas.Sexo+" | "+aguilas.ColorPlumaje+" | "+aguilas.Comer+" | "+aguilas.VolarAlto);
        }
        Console.ReadLine();   
        }else if (op=="0"){
            break;
              }
          }
        }
        public void ListaDePeces(){
                {
        while (true){
        Console.Clear();
        string op="";
        Console.WriteLine("\tLISTA DE PECES");
        Console.WriteLine("\t===============");
        Console.WriteLine("Si Desea ver pez globo PRESIONE (g) --si desea ver delfines PRESIONE (d) si desea SALIR PRESIONE (0)");
        op=Console.ReadLine();
        if(op=="g"){
        Console.Clear();
        Console.WriteLine("\tHAZ ELIGIDO PEZ GLOBO");
        Console.WriteLine("\tXXXXXXXXXXXXXXXX");
        Console.WriteLine("NOMBRE|EDAD|SEXO|NUMERO DE ALETAS|COMER|INFLARSE");
        
        foreach (var globo in ListaDePezGlobo)
        {
            Console.WriteLine(globo.Nombre+" | "+globo.Edad+" | "+globo.Sexo+" | "+globo.NumeroDeAletas+" | "+globo.Comer+" | "+globo.Inflarse);
        }
        Console.ReadLine();
        }else if(op=="d"){
        Console.Clear();
        Console.WriteLine("\tHAZ ELEGIDO DELFIN");
        Console.WriteLine("XXXXXXXXXXXXXXXX");
        Console.WriteLine("NOMBRE|EDAD|SEXO|NUMERO DE ALETAS|COMER|ECOLOCACION");
         foreach (var delfines in ListaDeDelfin)
        {
            Console.WriteLine(delfines.Nombre+" | "+delfines.Edad+" | "+delfines.Sexo+" | "+delfines.NumeroDeAletas+" | "+delfines.Comer+" | "+delfines.Ecolocacion);
        }
        Console.ReadLine();   
        }else if (op=="0"){
            break;
              }
              
                 }
             }

        }
    }
}