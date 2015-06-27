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
    public  class DetalleProformaMap:EntityTypeConfiguration<DetalleProforma>
    {
        public DetalleProformaMap()
        {
            this.HasKey(dp => dp.item);
            this.Property(dp => dp.item).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(dp => dp.Cantidad).IsRequired();
            this.Property(dp => dp.Precio).HasPrecision(18,2).IsRequired();


            this.ToTable("DetalleProforma");

            this.HasRequired(dp => dp.proforma)
                     .WithMany(prof => prof.detalleproforma)
                     .HasForeignKey(dp => dp.ProformaId)
                     .WillCascadeOnDelete(false);
        

        }
    }
}
