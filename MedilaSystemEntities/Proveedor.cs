using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedilaSystemEntities;

namespace MedilaSystemEntities
{
     public class Proveedor
    {
         public Proveedor()
         {
             this.hojadeDevolucion = new List<HojaDeDevolucion>();
             this.adquisicion = new List<Adquisicion>();
             this.producto = new List<Producto>();
           
         }

        public Int32 Id { get; set; }
        public string Ruc { get; set; }
        public string NombreE { get; set; }
        public string DireccionE { get; set; }
        public Int32 TelefonoE { get; set; }
        public string EmailE { get; set; }
        public string Cuidad { get; set; }
        public string NombreR { get; set; }
        public string ApellidosR { get; set; }
        public string CargoR { get; set; }
        public Int32 TelefonoR { get; set; }
        public string EmailR { get; set; }
        public string DireccionR { get; set; }
        

      
        

        public List<Adquisicion> adquisicion { get; set; }
        public List<HojaDeDevolucion> hojadeDevolucion { get; set; }
        public List<Producto>producto { get; set; }
    
    }
}
