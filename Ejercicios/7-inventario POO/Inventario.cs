using System;
using System.Collections.Generic;

public class Inventario
{
        
    public List<Producto> ListadeProductos { get; set; }
    public Inventario()
    {
        ListadeProductos = new List<Producto>();

        Producto a= new Producto("001","Cepillo Dental",10,100 );
        Producto b= new Producto("002","Pasta Dental",5,300 );
        Producto c= new Producto("003","Shampo",2,200 );
        Producto d= new Producto("004","Acondicionador",1,100);
        Producto e= new Producto("005","Jabon Corporal",5,0);

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
    Console.WriteLine("Codigo,Descripcion y Existencia ");

    foreach (var producto in ListadeProductos)
    {
        Console.WriteLine(producto.Codigo + "|"+ producto.Descripcion +"|"+ producto.Existencia.ToString()+"|"+producto.Valor.ToString());
    }
      Console.ReadLine();
}
private void movimientoInventario(string codigo, int cantidad,string tipoMovimiento){
       foreach (var  producto in ListadeProductos)
    {
         if(producto.Codigo==codigo){
            if(tipoMovimiento=="+"){
                producto.Existencia=producto.Existencia + cantidad;
                  }else{
                       producto.Existencia= producto.Existencia - cantidad;

                  }    
        }
    }
}
private void movimientoInventarioPrecio(string codigo, int precio,string tipoMovimiento){
       foreach (var  producto in ListadeProductos)
    {
         if(producto.Codigo==codigo){
            if(tipoMovimiento=="+"){
                producto.Valor=producto.Valor + precio;
                  }else{
                       producto.Valor= producto.Valor - precio;

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
        Console.WriteLine("Salida de Productos del inventario");
        Console.WriteLine("**********************************");
        Console.WriteLine("Ingrese el codigo del producto");
        codigo=Console.ReadLine();
        Console.WriteLine("");
        Console.WriteLine("Ingrese la cantidad del producto");
        cantidad=Console.ReadLine();

        movimientoInventario(codigo,Int32.Parse(cantidad),"-");
}
public void ajustePositivoDeInventario(){
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

        movimientoInventarioPrecio(codigo,Int32.Parse(precio),"+");
}
public void ajusteNegativoDeInventario(){
        string codigo="";
        string precio="";

        Console.Clear();
        Console.WriteLine("Salida de Productos del inventario");
        Console.WriteLine("**********************************");
        Console.WriteLine("Ingrese el codigo del producto");
        codigo=Console.ReadLine();
        Console.WriteLine("");
        Console.WriteLine("Disminuya el precio del producto");
        precio=Console.ReadLine();

        movimientoInventarioPrecio(codigo,Int32.Parse(precio),"-");
}
}