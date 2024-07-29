using System.Data;

Console.WriteLine("Tienda Panfila");

static void Menu()
{
    Console.WriteLine("1 = Ingresar producto");
    Console.WriteLine("2 = Pagar");
    Console.WriteLine("3 = Aplicar descuento");
}

static void IngresarProductos(string nombreProducto, double precioProducto, int contador = 0)
{
    int nuevo = 0;
    do
    {
        contador++;
        Console.WriteLine("Ingrese el nombre del producto");
        nombreProducto = Console.ReadLine();

        Console.WriteLine("Ingrese el precio del producto");
        precioProducto = Convert.ToDouble(precioProducto);

        for (int i = 0; i < contador; i++)
        {
            

        }

        Console.WriteLine("Desea ingresar otro producto?");
        Console.WriteLine("1 = SI");
        Console.WriteLine("2 = NO");
        nuevo = Convert.ToInt32(Console.ReadLine());
    } while (nuevo == 1);
}

static void Pagar()
{
}

static void AplicarDescuento()
{
}

