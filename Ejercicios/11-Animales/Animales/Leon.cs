using System;
namespace Animales
{
    class Leon:Mamiferos
    {
        public bool Rugir { get; set; }
       
    
    public Leon(string nombre, string edad,string sexo, string patas, string reproduccion, bool comer,bool rugir)
    {
        Nombre=nombre;
        Edad=edad;
        Sexo=sexo;
        Patas=patas;
        Reproduccion=reproduccion;
        Comer=comer;
        Rugir=rugir;
    }
    public void rugir(){
        Rugir=true;
    }
    }
}