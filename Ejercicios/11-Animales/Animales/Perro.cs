using System;
namespace Animales
{
    class Perro:Mamiferos
    {
        public string Raza{ get; set; }
        public bool Ladrar { get; set; }
       
    
    public Perro(string nombre, string edad,string sexo, string patas, string reproduccion, string raza,bool comer,bool ladrar)
    {
        Nombre=nombre;
        Edad=edad;
        Sexo=sexo;
        Patas=patas;
        Reproduccion=reproduccion;
        Raza=raza;
        Comer=comer;
        Ladrar=ladrar;
    }
    public void ladrar(){
        Ladrar=true;
    }
    }
}