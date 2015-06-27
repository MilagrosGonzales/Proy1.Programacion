using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedilaSystemEntities;

namespace MedilaSystemEntities
{
     public class DetalleProforma
    {
        public Int32 item { get; set; }
        public Int32 Cantidad  { get; set; }
        public decimal Precio{ get; set; }

        public Int32 ProformaId { get; set; }
        public Proforma proforma{ get; set; }
    }
}
