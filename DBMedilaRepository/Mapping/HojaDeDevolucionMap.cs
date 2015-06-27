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
    public  class HojaDeDevolucionMap:EntityTypeConfiguration<HojaDeDevolucion>
    {
         public HojaDeDevolucionMap()
          {
              
             this.HasKey(hd=>hd.Id);
             this.Property(hd => hd.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
             this.Property(hd => hd.Fecha).IsRequired();


             this.ToTable("HojaDevoluciones");

             this.HasRequired(hd => hd.proveedor)
                      .WithMany(prov=> prov.hojadeDevolucion)
                      .HasForeignKey(hd => hd.ProveedorId)
                      .WillCascadeOnDelete(false);
        
     }
    }
}
