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
     public  class AdquisicionMap:EntityTypeConfiguration<Adquisicion>
    {
          public AdquisicionMap()
          {
              
             this.HasKey(ad=>ad.Id);
             this.Property(ad => ad.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
             this.Property(ad => ad.Fecha).IsRequired();


             this.ToTable("Adquisiciones");

             this.HasRequired(ad => ad.proveedor)
                      .WithMany(prov=> prov.adquisicion)
                      .HasForeignKey(ad => ad.ProveedorId)
                      .WillCascadeOnDelete(false);
        
     }
    }
}
