using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedilaSystemEntities;

namespace MedilaSystemEntities
{
     public class DetalleAdquisicion
    {
        public Int32 item { get; set; }
        public Int32 ProductoId { get; set; }
        public Producto  producto{ get; set; }
        public Int32 adquisicionId { get; set; }
        public Adquisicion adquisicion { get; set; }
    }
}
