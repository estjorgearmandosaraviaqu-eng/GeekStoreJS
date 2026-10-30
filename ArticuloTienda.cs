using System;

namespace GeekStoreJS
{
    public abstract class ArticuloTienda
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public double PrecioCosto { get; set; }
        public double PrecioVenta { get; set; }
        public int Stock { get; set; }

        public ArticuloTienda(int id, string nombre, double precioCosto, double precioVenta, int stock)
        {
            ID = id;
            Nombre = nombre;
            PrecioCosto = precioCosto;
            PrecioVenta = precioVenta;
            Stock = stock;
        }

        public abstract void MostrarDetalles();
    }
}

