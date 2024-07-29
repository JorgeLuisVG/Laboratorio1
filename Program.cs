using System.Data;

namespace Programa1
{
    internal class Program
    {
        static string nombreProducto;
        static double precioProducto;
        static string[] nameProducto = new string[0];
        static double[] priceProductos = new double[0];

        static void Main(string[] args)
        {
            static void Menu()
            {
                Console.WriteLine("Tienda Panfila");
                Console.WriteLine("1 = Ingresar producto");
                Console.WriteLine("2 = Pagar");
                Console.WriteLine("3 = Aplicar descuento");
            }

            static void IngresarProductos()
            {
                int contador = 0;
                int nuevo = 0;
                do
                {
                    contador++;
                    Console.WriteLine("Ingrese el nombre del producto");
                    nombreProducto = Console.ReadLine();

                    nameProducto[contador] = nombreProducto;

                    Console.WriteLine("Ingrese el precio del producto");
                    precioProducto = Convert.ToDouble(Console.ReadLine());

                    priceProductos[contador] = precioProducto;

                    Console.WriteLine("Desea ingresar otro producto?");
                    Console.WriteLine("1 = SI");
                    Console.WriteLine("2 = NO");
                    nuevo = Convert.ToInt32(Console.ReadLine());
                } while (nuevo == 1);
            }

            static void Pagar()
            {
                IngresarProductos();



            }

            static void AplicarDescuento()
            {

            }
        }
    }
}