using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedilaSystemEntities;

namespace MedilaSystemEntities
{
  public class HojaDeDevolucion
    {
      public HojaDeDevolucion()
      {
          this.DetalleDevolucion = new List<DetalleDeDevolucion>();
          this.Fecha = DateTime.Now;
      }
      public Int32 Id { get; set; }
      public DateTime Fecha { get; set; }
      public Int32 ProveedorId { get; set; }
      public Proveedor proveedor { get; set; }
        public List<DetalleDeDevolucion> DetalleDevolucion { get; set; }
       
    }
}
