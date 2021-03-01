using System;

namespace inventario
{
    class Program
    {
        static string [,]productos=new string [5,4]{
            {"001","Cepillo Dental","10","100"},
            {"002","Pasta Dental","5","300"},
            {"003","Shampo","2","200"},
            {"004","Acondicionador","1","100"},
            {"005","Jabon Corporal","5","0"},
        } ; 
    
static void listarProductos(){
    Console.Clear();
    Console.WriteLine("");
    Console.WriteLine("Litado de Productos");
    Console.WriteLine("*******************");
    Console.WriteLine("Codigo,Descripcion,existencia y precio");

    for(int i=0;i<5;i++){
        Console.WriteLine(productos[i,0]+"|"+ productos[i,1]+"|"+ productos[i,2]+"|"+ productos[i,3]);
    }
      Console.ReadLine();
}
 static void movimientoInventario(string codigo, int cantidad,string tipoMovimiento){
    for(int i=0;i<5;i++){
        if(productos[i,0]==codigo){
            if(tipoMovimiento=="+"){
                productos[i,2]=(Int32.Parse(productos[i,2])+ cantidad).ToString();
                  }else{
                      productos[i,2]=(Int32.Parse(productos[i,2])- cantidad).ToString();
                  }
        }
    }
}
 static void movimientoPrecio(string codigo, int precio,string tipoMovimiento){
    for(int i=0;i<5;i++){
        if(productos[i,0]==codigo){
            if(tipoMovimiento=="+"){
                productos[i,3]=(Int32.Parse(productos[i,3])+ precio).ToString();
                  }else{
                      productos[i,3]=(Int32.Parse(productos[i,3])- precio).ToString();
                  }
        }
    }
}
static void ingresoDeInventario(){
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
static void salidaDeInventario(){
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
static void ingresoPositivoDeInventario(){
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
static void ingresoNegativoDeInventario(){
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
        static void Main(string[] args)
        {
            string opcion="";
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Sistema de Inventario");
                Console.WriteLine("*********************");
                Console.WriteLine("");
                Console.WriteLine("1 - Productos");
                Console.WriteLine("2 - Ingreso de Inventario");
                Console.WriteLine("3 - Salida de Inventario");
                Console.WriteLine("4 - Ajuste Positivo De Inventario--Precio");
                Console.WriteLine("5 - Ajuste Negativo De Inventario--Precio");
                Console.WriteLine("0 - Salir");
                opcion=Console.ReadLine();

                switch(opcion){
                    case "1":
                    listarProductos();
                      break;
                    case "2":
                    ingresoDeInventario();
                    break;
                    case "3":
                    salidaDeInventario();
                    break;
                    case "4":
                    ingresoPositivoDeInventario();
                    break;
                    case "5":
                    ingresoNegativoDeInventario();
                    break;
                     default:
                    break;
                }
              
                if(opcion=="0"){
                    break;
                }
            }
        }
    }
}
