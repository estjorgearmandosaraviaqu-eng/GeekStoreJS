
using System;

namespace GeekStoreJS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tienda tienda = new Tienda();
            string opcion = "";

            while (opcion != "5")
            {
                Console.WriteLine("      GEEK STORE     ");
                Console.WriteLine("1. Ver inventario y saldo de caja");
                Console.WriteLine("2. Añadir un nuevo comic");
                Console.WriteLine("3. Añadir nuevo merchandising");
                Console.WriteLine("4. Realizar una venta");
                Console.WriteLine("5. Salir");
                Console.Write("Seleccione una opcion: ");

                opcion = Console.ReadLine() ?? "";

                switch (opcion)
                {
                    case "1":
                        tienda.MostrarInventario();
                        break;

                    case "2":
                        Console.WriteLine("\n    REGISTRAR COMIC    ");

                        Console.Write("ID: ");
                        int idComic = int.Parse(Console.ReadLine());

                        Console.Write("Nombre: ");
                        string nombreComic = Console.ReadLine();

                        Console.Write("Precio de costo: ");
                        double costoComic =
                            double.Parse(Console.ReadLine());

                        Console.Write("Precio de venta: ");
                        double ventaComic =
                            double.Parse(Console.ReadLine());

                        Console.Write("Cantidad a comprar: ");
                        int cantidadComic =
                            int.Parse(Console.ReadLine());

                        Console.Write("Volumen: ");
                        int volumen = int.Parse(Console.ReadLine());

                        Console.Write("Es variante? (true/false): ");
                        bool esVariante = bool.Parse(Console.ReadLine());

                        Comic comic = new Comic(idComic,nombreComic,costoComic,ventaComic,cantidadComic,volumen,esVariante );

                        tienda.AgregarAlInventario(
                            comic, cantidadComic);
                        break;

                    case "3":
                        Console.WriteLine("\n     REGISTRAR MERCHANDISING      ");

                        Console.Write("ID: ");
                        int idMerch = int.Parse(Console.ReadLine());

                        Console.Write("Nombre: ");
                        string nombreMerch = Console.ReadLine();

                        Console.Write("Precio de costo: ");
                        double costoMerch =
                            double.Parse(Console.ReadLine());

                        Console.Write("Precio de venta: ");
                        double ventaMerch =
                            double.Parse(Console.ReadLine());

                        Console.Write("Cantidad a comprar: ");
                        int cantidadMerch =
                            int.Parse(Console.ReadLine());

                        Console.Write("Tipo (Polera/Taza): ");
                        string tipo = Console.ReadLine();

                        Console.Write("Talla (N/A si es taza): ");
                        string talla = Console.ReadLine();

                        Merchandising merchandising =
                            new Merchandising(idMerch,nombreMerch,costoMerch,ventaMerch,cantidadMerch,tipo,talla );
                        //naci por mi madre, morire odiando a git hub
                        tienda.AgregarAlInventario(merchandising, cantidadMerch);
                        break;
                    case "4":
                        Console.WriteLine("\n    REALIZAR VENTA    ");

                        Console.Write("ID del articulo: ");
                        int idArticulo =
                            int.Parse(Console.ReadLine()!);

                        Console.Write("Cantidad a vender: ");
                        int cantidadVenta =
                            int.Parse(Console.ReadLine()!);

                        tienda.VenderArticulo(
                            idArticulo, cantidadVenta);
                        break;

                    case "5":
                        Console.WriteLine(
                            "Gracias por visitar GEEK STORE.");
                        break;

                    default:
                        Console.WriteLine(
                            "Opcion no valida. Intente nuevamente.");
                        break;
                }
            }
        }
    }
}

