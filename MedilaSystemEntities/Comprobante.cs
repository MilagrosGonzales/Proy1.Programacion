using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedilaSystemEntities
{
     public class Comprobante
    {

         public Comprobante()
         {
             this.venta = new List<Venta>();
         }

        public Int32 Id { get; set; }
        public decimal IGV { get; set; }
        public string TipoComprobante { get; set; }

       
        public List<Venta> venta { get; set; }

       
    }
}
