using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedilaSystemEntities
{
     public class ComprobanteF
    {
       

        public Int32 Id { get; set; }
        public decimal Total { get; set; }
        public decimal subTotal { get; set; }
        public decimal Igv { get; set; }

        public Int32 ventaId { get; set; }
        public Venta venta{ get; set; }
       
  
    }
}
