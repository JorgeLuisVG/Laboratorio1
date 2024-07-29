using System.Data;

namespace Programa1
{
    internal class Program
    {
        static string nombreProducto;
        static double precioProducto;
        static string[] nameProducto = new string[0];
        static double[] priceProductos = new double[0];
        static int contador = 1;
        static double total = 0;
        static double suma;
        static double descuento;

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

            Menu();
            int opcion = Convert.ToInt32(Console.ReadLine());
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
                opcion = Convert.ToInt32(Console.ReadLine());
            } while (opcion == 1);
        }
    }
}