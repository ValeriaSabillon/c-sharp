using System;
using System.Collections.Generic;
public class Inventario
{

public List<Producto> ListadeProductos{ get; set; }
public Inventario()
{
    ListadeProductos= new List<Producto>();

    Producto a= new Producto("001","iPhoneX",0);
    Producto b= new Producto("002","Dell",5);
    Producto c= new Producto("003","Monitor Samsung",2);
    Producto d= new Producto("004","Mouse",100);
    Producto e= new Producto("005","Headset",25);

    ListadeProductos.Add(a);
    ListadeProductos.Add(b);
    ListadeProductos.Add(c);
    ListadeProductos.Add(d);
    ListadeProductos.Add(e);
}

public void listarProductos(){
    Console.Clear();
    Console.WriteLine("");
    Console.WriteLine("Litado de Productos");
    Console.WriteLine("*******************");
    Console.WriteLine("Codigo,Descripcion,existencia y precio");

      foreach (var producto in ListadeProductos)
      {
          Console.WriteLine(producto.Codigo+"|"+producto.Descripcion+"|"+producto.Existencia.ToString()+"|"+producto.Valor.ToString());
      }
}
private void movimientoInventario(string codigo, int cantidad,string tipoMovimiento){
    
     foreach (var producto in ListadeProductos)
      {
        if(producto.Codigo==codigo){
            if(tipoMovimiento=="+"){
                producto.Existencia=producto.Existencia + cantidad;
                  }else{
                producto.Existencia=producto.Existencia - cantidad;
                  }
        }
      }
}
private void movimientoPrecio(string codigo, int precio,string tipoMovimiento){
    foreach (var producto in ListadeProductos)
    {
        if(producto.Codigo==codigo){
            if(tipoMovimiento=="+"){
                producto.Valor=producto.Valor+precio;
            }else{
                producto.Valor=producto.Valor-precio;

            }
        }
    }
    
    }
public void ingresoDeInventario(){
        string codigo="";
        string cantidad="";
        

        Console.Clear();
        Console.WriteLine("Ingreso de Productos al inventario");
        Console.WriteLine("**********************************");
        Console.WriteLine("Ingrese el codigo del producto");
        codigo=Console.ReadLine();
        Console.WriteLine("");
        Console.WriteLine("Ingrese la cantidad del producto");
        cantidad=Console.ReadLine();

        movimientoInventario(codigo,Int32.Parse(cantidad),"+");
}
public void salidaDeInventario(){
        string codigo="";
        string cantidad="";

        Console.Clear();
        Console.WriteLine("Ingreso de Productos al inventario");
        Console.WriteLine("**********************************");
        Console.WriteLine("Ingrese el codigo del producto");
        codigo=Console.ReadLine();
        Console.WriteLine("");
        Console.WriteLine("Ingrese la cantidad del producto");
        cantidad=Console.ReadLine();

        movimientoInventario(codigo,Int32.Parse(cantidad),"-");
}
public void ingresoPositivoDeInventario(){
        string codigo="";
        string precio="";

        Console.Clear();
        Console.WriteLine("Ingreso de Productos al inventario");
        Console.WriteLine("**********************************");
        Console.WriteLine("Ingrese el codigo del producto");
        codigo=Console.ReadLine();
        Console.WriteLine("");
        Console.WriteLine("Ingrese el precio del producto");
        precio=Console.ReadLine();

        movimientoPrecio(codigo,Int32.Parse(precio),"+");
}
public void ingresoNegativoDeInventario(){
        string codigo="";
        string precio="";

        Console.Clear();
        Console.WriteLine("Ingreso de Productos al inventario");
        Console.WriteLine("**********************************");
        Console.WriteLine("Ingrese el codigo del producto");
        codigo=Console.ReadLine();
        Console.WriteLine("");
        Console.WriteLine("Disminuya el precio del producto");
        precio=Console.ReadLine();

        movimientoPrecio(codigo,Int32.Parse(precio),"-");

    }
}