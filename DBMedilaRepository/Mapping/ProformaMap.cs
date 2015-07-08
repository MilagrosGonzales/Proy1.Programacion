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
    public class ProformaMap:EntityTypeConfiguration<Proforma>
    {
        public ProformaMap()
        {
            this.HasKey(prof=>prof.Id);
            this.Property(prof => prof.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(prof => prof.Fecha).IsRequired();
            this.Property(prof=> prof.total).HasPrecision(18,2).IsRequired();
           
          

             this.ToTable("Proformas");

             this.HasRequired(prof => prof.cliente)
                      .WithMany(c=> c.Proforma)
                      .HasForeignKey(prof => prof.ClienteId)
                      .WillCascadeOnDelete(false);

            
            
        }
    }
}
