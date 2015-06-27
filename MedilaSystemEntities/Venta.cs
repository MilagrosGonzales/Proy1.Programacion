using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedilaSystemEntities;

namespace MedilaSystemEntities
{
   public  class Venta
    {
       public Venta()
       {
          
           this.detalleVenta = new List<DetalleVenta>();
           this.comprobanteB = new List<ComprobanteB>();
           this.comprobanteF = new List<ComprobanteF>();
        
        }
        public Int32 Id { get; set; }
        public Decimal Total  { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime HoraSalida { get; set; }
        public DateTime? HoraRegistro { get; set; }
        public string Plazos { get; set; }
        
        public Int32 clienteId { get; set; }
        public Cliente cliente  { get; set; }


        public List<DetalleVenta>detalleVenta { get; set; }
        public List<ComprobanteB> comprobanteB { get; set; }
        public List<ComprobanteF> comprobanteF { get; set; }
    
       

         
    }
}
