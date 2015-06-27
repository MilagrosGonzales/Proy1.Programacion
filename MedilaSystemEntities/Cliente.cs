using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedilaSystemEntities
{
     public class Cliente
    {
         public Cliente()
         {
             this.Proforma = new List<Proforma>();
             this.Venta = new List<Venta>();
         }

        public Int32 Id { get; set; }
        public string TipoCliente { get; set; }
        public int RucDni { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        
        public List<Proforma> Proforma { get; set; }
        public List<Venta> Venta { get; set; }

        public override string ToString()
        {
            return Nombre+" "+Apellidos;
        }
    }
}
