using System;
namespace Animales
{
    class Loro:Aves
    {
        public bool Hablar{ get; set; }
       
    
    public Loro(string nombre, string edad,string sexo,string colorplumaje,bool comer, bool hablar )
    {
        Nombre=nombre;
        Edad=edad;
        Sexo=sexo;
        ColorPlumaje=colorplumaje;
        Comer=comer;
        Hablar=hablar;

      
    }
    public void hablar (){
        Hablar=true;
    } 
    }
}