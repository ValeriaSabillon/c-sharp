using System;
namespace Animales
{
    class Delfin:Peces
    {
        public bool Ecolocacion{ get; set; }
       
    
    public Delfin(string nombre, string edad,string sexo,string numeroDeAletas,bool comer,bool ecolocacion )
    {
        Nombre=nombre;
        Edad=edad;
        Sexo=sexo;
        NumeroDeAletas=numeroDeAletas;
        Comer=comer;      
        Ecolocacion=ecolocacion;
    }
    public void ecolocacion (){
        Ecolocacion=true;
    } 
    }
}