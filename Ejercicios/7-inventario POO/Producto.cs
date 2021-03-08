public class Producto
{
    public  string Codigo { get; set; }
    public  string Descripcion { get; set; }
    public  int Existencia{ get; set; }
    public int Valor { get; set; }
    public Producto(string codigo, string descripcion, int existencia, int valor)
    {
        Codigo=codigo;
        Descripcion=descripcion;
        Existencia= existencia;
        Valor=valor;
    }
  
}