using System;
using System.Collections.Generic;
using System.Text;

namespace GeekStoreJS
{
    public class Merchandising : ArticuloTienda, IComercializable
    {
        public string Tipo { get; set; }
        public string Talla { get; set; }

        public Merchandising(int id, string nombre, double precioCosto, double precioVenta, int stock, string tipo, string talla)
            : base(id, nombre, precioCosto, precioVenta, stock)
        {
            Tipo = tipo;
            Talla = talla;
        }

        public double CalcularTotalVenta(int cantidadComprada)
        {
            return PrecioVenta * cantidadComprada;
        }

        public override void MostrarDetalles()
        {
            Console.WriteLine("      MERCHANDISING      ");
            Console.WriteLine("ID: " + ID);
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Precio Costo: " + PrecioCosto);
            Console.WriteLine("Precio Venta: " + PrecioVenta);
            Console.WriteLine("Stock: " + Stock);
            Console.WriteLine("Tipo: " + Tipo);
            Console.WriteLine("Talla: " + Talla);

        }
    }
}
