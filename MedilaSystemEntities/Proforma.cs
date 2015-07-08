using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedilaSystemEntities
;

namespace MedilaSystemEntities
{
     public class Proforma
    {
         public Proforma()
         {
             this.venta = new List<Venta>();
             this.detalleproforma= new  List<DetalleProforma>();
            
         }
        public Int32 Id { get; set; }
        public DateTime Fecha { get; set; }
        public Int32 ClienteId { get; set; }
        public Cliente cliente { get; set; }
        
        
        public Decimal total { get; set; }
   
        

       public List<Venta> venta { get; set; }
       public List<DetalleVenta>detalleventa { get; set; }
       public List<DetalleProforma> detalleproforma { get; set; }
    }
}
