using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedilaSystemEntities;

namespace MedilaSystemEntities
{
     public class DetalleDeDevolucion
    {
         public Int32 item { get; set; }
         public Int32 ProductoId { get; set; }
         public Producto producto { get; set; }
         public Int32 hojaDevolucionId { get; set; }
         public HojaDeDevolucion hojaDevolucion { get; set; }

    }
}
