using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedilaSystemEntities;

namespace MedilaSystemEntities
{
    public  class Adquisicion
    {
        public Adquisicion()
        {
            this.DetalleAdquisicion = new List<DetalleAdquisicion>();
            this.Fecha = DateTime.Now;
                
        }
         
        public Int32 Id { get; set; }
        public DateTime Fecha { get; set; }
        public Int32 ProveedorId { get; set; }
        public Proveedor proveedor { get; set; }

        public List<DetalleAdquisicion>DetalleAdquisicion{ get; set; }

    }
}
