using System.Data;

namespace Programa1
{
    internal class Program
    {
        static string nombreProducto;
        static double precioProducto;
        static string[] nameProducto = new string[contador];
        static double[] priceProductos = new double[contador];
        static int contador = 0;
        static double total = 0, suma, descuento;
        static bool continuar = true;

        static void Main(string[] args)
        {
            static void Menu()
            {
                Console.WriteLine("Tienda Panfila");
                Console.WriteLine("1 = Pagar");
                Console.WriteLine("2 = Aplicar descuento");
            }

            static void IngresarProductos()
            {
                int nuevo = 0;
                do
                {
                    contador++;
                    Console.WriteLine("Ingrese el nombre del producto");
                    nombreProducto = Console.ReadLine();

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
                foreach (double x in priceProductos)
                {
                    suma += x;
                }
                total = suma;
                Console.WriteLine("su total a pagar es de: " + suma);
            }

            static void AplicarDescuento()
            {
                Console.WriteLine("Aplique el porcentaje de descuento con el que cuenta");
                descuento = Convert.ToDouble(Console.ReadLine());

                descuento = descuento / 100;

                total = total - (total * descuento);
            }
            int opcion = 0;
            Menu();
            while (continuar)
            {
                try
                {
                    opcion = Convert.ToInt32(Console.ReadLine());
                    continuar = false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error " + ex.Message);
                    continuar = true;
                }
            }
            do
            {
                switch (opcion)
                {
                    case 1:
                        Pagar();
                        break;
                    case 2:
                        AplicarDescuento();
                        break;
                }
                Console.WriteLine("Desea finalizar?");
                Console.WriteLine("1 = si");
                Console.WriteLine("2 = no");
                while (continuar)
                {
                    try
                    {
                        opcion = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error " + ex.Message);
                        continuar = true;
                    }
                }
            } while (opcion == 1);
        }
    }
}