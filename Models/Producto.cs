using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperTienda.Models
{
    class Producto
    {
        public int idProducto { get; set; }
        public int idCategoria { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }

        public string imagen { get; set; }

        public double precioCompra { get; set; }
        public double precioVenta { get; set; }

        public bool disponible { get; set; }

        public Producto() { }
    }
}
