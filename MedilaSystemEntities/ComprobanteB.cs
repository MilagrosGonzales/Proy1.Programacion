using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedilaSystemEntities
{
     public class ComprobanteB
    {
         

        public Int32 Id { get; set; }
        public decimal Total { get; set; }

        public Int32 VentaId { get; set; }
        public Venta venta{ get; set; }

       
    }
}
