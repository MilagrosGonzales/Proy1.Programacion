using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using MedilaSystemEntities;

using System.ComponentModel.DataAnnotations.Schema;

namespace DBMedilaRepository.Mapping
{
   public  class ProveedorMap:EntityTypeConfiguration<Proveedor>
    {
       public ProveedorMap()
       {
           
            this.HasKey(prov=>prov.Id);
            this.Property(prov => prov.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(prov => prov.Ruc).HasMaxLength(20).IsRequired();
            this.Property(prov => prov.NombreE).HasMaxLength(200).IsRequired();
            this.Property(prov=> prov.DireccionE).HasMaxLength(200).IsRequired();
            this.Property(prov=>prov.TelefonoE).IsRequired();
            this.Property(prov => prov.EmailE).HasMaxLength(200).IsRequired();
            this.Property(prov => prov.Cuidad).HasMaxLength(200).IsRequired();
            this.Property(prov => prov.NombreR).HasMaxLength(200).IsRequired();
            this.Property(prov=> prov.CargoR).HasMaxLength(200).IsRequired();
            this.Property(prov=>prov.TelefonoR).IsRequired();
            this.Property(prov => prov.EmailR).HasMaxLength(200).IsRequired();
            this.Property(prov => prov.DireccionR).HasMaxLength(200).IsRequired();

           

             this.ToTable("Proveedores");
        
       }
    }
}
