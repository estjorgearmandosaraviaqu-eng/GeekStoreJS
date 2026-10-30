using System;
using System.Collections.Generic;
using System.Text;

namespace GeekStoreJS
{
    public class Tienda
    {
        private List<ArticuloTienda> inventario;

        public double SaldoCaja { get; private set; }

        public Tienda()
        {
            inventario = new List<ArticuloTienda>();
            SaldoCaja = 1000.0;
        }
        public void AgregarAlInventario(ArticuloTienda nuevoArticulo, int cantidadAComprar)
        {
            if (nuevoArticulo == null)
            {
                Console.WriteLine("El artículo no es válido.");
                return;
            }

            if (cantidadAComprar <= 0)
            {
                Console.WriteLine("La cantidad debe ser mayor a cero.");
                return;
            }

            double costoTotal = nuevoArticulo.PrecioCosto * cantidadAComprar;

            if (SaldoCaja < costoTotal)
            {
                Console.WriteLine("No hay suficiente dinero en caja para realizar la compra.");
                return;
            }

            ArticuloTienda articuloExistente = null;

            foreach (ArticuloTienda articulo in inventario)
            {
                if (articulo.ID == nuevoArticulo.ID)
                {
                    articuloExistente = articulo;
                    break;
                }
            }

            if (articuloExistente != null)
            {
                articuloExistente.Stock += cantidadAComprar;
            }
            else
            {
                nuevoArticulo.Stock = cantidadAComprar;
                inventario.Add(nuevoArticulo);
            }
            SaldoCaja -= costoTotal;

            Console.WriteLine("Producto agregado correctamente al inventario.");
            Console.WriteLine("Costo total de compra: Bs " + costoTotal);
            Console.WriteLine("Saldo actual: Bs " + SaldoCaja);
        }
        public void MostrarInventario()
        {
            Console.WriteLine("INVENTARIO DE GEEK STORE");

            if (inventario.Count == 0)
            {
                Console.WriteLine("\n El inventario está vacío.");
                Console.WriteLine("\n Saldo en caja: Bs " + SaldoCaja + "\n");
                return;
            }
          
            foreach (ArticuloTienda articulo in inventario)
            {
                articulo.MostrarDetalles();
            }
           
            Console.WriteLine("\n Saldo en caja: Bs " + SaldoCaja + "\n");

        }
        public void VenderArticulo(int idArticulo, int cantidadAVender)
        {
            if (cantidadAVender <= 0)
            {
                Console.WriteLine("La cantidad debe ser mayor a cero.");
                return;
            }

            ArticuloTienda articuloEncontrado = null;

            foreach (ArticuloTienda articulo in inventario)
            {
                if (articulo.ID == idArticulo)
                {
                    articuloEncontrado = articulo;
                    break;
                }
            }

            if (articuloEncontrado == null)
            {
                Console.WriteLine("No se encontró un artículo con ese ID.");
                return;
            }

            if (articuloEncontrado.Stock < cantidadAVender)
            {
                Console.WriteLine("No hay suficiente stock disponible.");
                return;
            }

            IComercializable producto = articuloEncontrado as IComercializable;

            if (producto == null)
            {
                Console.WriteLine("El artículo no permite realizar ventas.");
                return;
            }

            double totalVenta = producto.CalcularTotalVenta(cantidadAVender);

            articuloEncontrado.Stock -= cantidadAVender;
            SaldoCaja += totalVenta;

            Console.WriteLine(" COMPROBANTE DE VENTA ");
            Console.WriteLine("Producto: " + articuloEncontrado.Nombre);
            Console.WriteLine("Cantidad: " + cantidadAVender);
            Console.WriteLine("Total: Bs " + totalVenta);
            Console.WriteLine("Saldo actual en caja: Bs " + SaldoCaja);

        }
    }
}
