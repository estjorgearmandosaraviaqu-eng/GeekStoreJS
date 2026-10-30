using System;
using System.Collections.Generic;
using System.Text;

namespace GeekStoreJS
{
    public class Comic : ArticuloTienda, IComercializable
    {
        public int Volumen { get; set; }
        public bool EsVariante { get; set; }

        public Comic(int id, string nombre, double precioCosto,double precioVenta, int stock, int volumen,bool esVariante)
            : base(id, nombre, precioCosto, precioVenta, stock)
        {
            Volumen = volumen;
            EsVariante = esVariante;
        }

        public double CalcularTotalVenta(int cantidadComprada)
        {
            double total = PrecioVenta * cantidadComprada;

            if (EsVariante)
            {
                total = total * 1.20;
            }

            return total;
        }

        public override void MostrarDetalles()
        {
            Console.WriteLine("      COMIC     ");
            Console.WriteLine("ID: " + ID);
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Precio Costo: " + PrecioCosto);
            Console.WriteLine("Precio Venta: " + PrecioVenta);
            Console.WriteLine("Stock: " + Stock);
            Console.WriteLine("Volumen: " + Volumen);
            Console.WriteLine("Es Variante: " + (EsVariante ? "Si" : "No"));

        }
    }
}
