namespace Animales
{
    abstract  class Peces:Animal
    {
        public string NumeroDeAletas{ get; set; }

        public bool Nadar { get; set; }
       
   
    public void nadar(){
        Nadar=true;
    }
}
}