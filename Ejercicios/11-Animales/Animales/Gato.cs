using System;
namespace Animales
{
    class Gato:Mamiferos
    {
        public string Pelaje{ get; set; }
        public bool Maullar { get; set; }
       
    
    public Gato(string nombre, string edad,string sexo, string patas, string reproduccion,string pelaje,bool comer,bool maullar)
    {
        Nombre=nombre;
        Edad=edad;
        Sexo=sexo;
        Patas=patas;
        Reproduccion=reproduccion;
        Pelaje=pelaje;
        Comer=comer;
        Maullar=maullar;


    }
    public void maullar(){
        Maullar=true;
    }
    }
}