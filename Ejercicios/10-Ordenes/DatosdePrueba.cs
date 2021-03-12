using System;
using System.Collections.Generic;

public class DatosdePrueba
{
    public List<Producto> ListadeProductos{ get; set; }
    public  List<Cliente> ListadeClientes{ get; set; }
    public  List<Vendedor> ListadeVendedores{ get; set; }
    public DatosdePrueba()
    {
        ListadeProductos= new List<Producto>();
        cargarProductos();

        ListadeClientes= new List<Cliente>();
        cargarClientes();

        ListadeVendedores= new List<Vendedor>();
        cargarVendedores();
    }

private void cargarClientes()
{
    Cliente c1= new Cliente (1,"Juan","7777");
    ListadeClientes.Add(c1);

    Cliente c2= new Cliente (2,"Pedro","9999");
    ListadeClientes.Add(c2);

    
}
 public void ListarClientes()
    {   
        Console.Clear();
        Console.WriteLine("Lista de Cliente");
        Console.WriteLine("******************");
        Console.WriteLine("");

        foreach (var cliente in ListadeClientes)
        {
            Console.WriteLine(cliente.Codigo +"|"+ cliente.Nombre +"|"+ cliente.Telefono);
        }
        Console.ReadLine();
    }

private void cargarVendedores()
{
        Vendedor v1= new Vendedor(1,"Jose","V001");
        ListadeVendedores.Add(v1);

        Vendedor v2= new Vendedor(2,"Pablo","V002");
        ListadeVendedores.Add(v2);

}
 public void ListarVendedores()
    {   
        Console.Clear();
        Console.WriteLine("Lista de Vendedores");
        Console.WriteLine("******************");
        Console.WriteLine("");

        foreach (var vendedor in ListadeVendedores)
        {
            Console.WriteLine(vendedor.Codigo +"|"+ vendedor.Nombre +"|"+ vendedor.CodigoVendedor);
        }
        Console.ReadLine();
    }
 
  private void cargarProductos()
    {
        Producto p1= new Producto(1,"Mouse",250);
        ListadeProductos.Add(p1);

        Producto p2= new Producto(2,"Teclado",350);
        ListadeProductos.Add(p2);

        Producto p3= new Producto(3,"Monitor",4000);
        ListadeProductos.Add(p3);
    }
    public void ListarProductos()
    {   
        Console.Clear();
        Console.WriteLine("Lista de Productos");
        Console.WriteLine("******************");
        Console.WriteLine("");

        foreach (var producto in ListadeProductos)
        {
            Console.WriteLine(producto.Codigo +"|"+ producto.Descripcion +"|"+ producto.Precio);
        }
        Console.ReadLine();
    }
}