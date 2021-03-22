using System;
namespace Animales
{
    class PezGlobo:Peces
    {
        public bool Inflarse{ get; set; }
       
    
    public PezGlobo(string nombre, string edad,String sexo,string numeroDeAletas,bool comer,bool inflarse )
    {
        Nombre=nombre;
        Edad=edad;
        Sexo=sexo;
        NumeroDeAletas=numeroDeAletas;
        Comer=comer;
        Inflarse=inflarse;  
           
    }
    public void inflarse (){
        Inflarse=true;
    } 
    }
}