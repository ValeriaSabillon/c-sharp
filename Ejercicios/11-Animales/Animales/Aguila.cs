using System;
namespace Animales
{
    class Aguila:Aves
    {
        public bool VolarAlto{ get; set; }
       
    
    public Aguila(string nombre, string edad,string sexo,string colorplumaje,bool comer,bool volaralto )
    {
        Nombre=nombre;
        Edad=edad;
        Sexo=sexo;
        ColorPlumaje=colorplumaje;
        Comer=comer;
        VolarAlto=volaralto;
      
    }
    public void volaralto (){
        VolarAlto=true;
    } 
    }
}