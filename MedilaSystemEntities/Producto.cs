using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  MedilaSystemEntities;
using MedilaSystemEntities;

namespace MedilaSystemEntities
{
     public class Producto
     {
         public Producto()
         {
             this.detalleadquisicion = new List<DetalleAdquisicion>();
             this.detallehojaDevolucion = new  List<DetalleDeDevolucion>();
             this.detalleventa= new List<DetalleVenta>();
             this.detalleproforma= new List<DetalleProforma>();
             this.proforma = new List<Proforma>();
             
             
         }
        public Int32 Id { get; set; }
        public string Nombre{ get; set; }
        public string Descripcion { get; set; }
        public Decimal PrecioUnitarioDeCompra { get; set; }
        public Decimal PrecioUnitarioDeVenta { get; set; }
        public Int32 ProveedorId { get; set; }
        public bool IsEstado { get; set; }
        public Proveedor provedor { get; set; }
       
         
        public List<DetalleAdquisicion>  detalleadquisicion{ get; set; }
        public List<DetalleDeDevolucion> detallehojaDevolucion { get; set; }
        public List<DetalleVenta> detalleventa { get; set; }
        public List<DetalleProforma> detalleproforma{ get; set; }
        public List<Proforma> proforma{ get; set; }
        public List<Adquisicion> adquisicion { get; set; }
       
         

    }
}
