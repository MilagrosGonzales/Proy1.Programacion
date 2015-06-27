using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedilaSystemEntities;

namespace MedilaSystemEntities
{
     public class DetalleVenta
    {
         public Int32 Item { get; set; }
   
        public Int32 Cantidad { get; set; }
        public decimal Precio { get; set; }
        public Int32 ProductoId { get; set; }
        public Producto producto { get; set; }

        public Int32 VentaId { get; set; }
        public Venta venta { get; set; }

        public decimal Monto
        {
            get
            {
                return Precio * Cantidad;
            }
        }
         
    }
}
