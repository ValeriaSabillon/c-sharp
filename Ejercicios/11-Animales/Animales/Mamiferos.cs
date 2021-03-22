
namespace Animales
{
    abstract  class Mamiferos:Animal
    {
        public string Patas{ get; set; }
        public string Reproduccion { get; set; }

        public bool Caminar { get; set; }
       
       public void caminar()
       {
        Caminar=true;
    }
    }
    
}