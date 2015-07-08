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
            //key
            this.HasKey(it => new { it.ProformaId, it.ProductoId });

            //propiedades
            this.Property(it => it.ProformaId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            this.Property(it => it.ProductoId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None); this.Property(dp => dp.Cantidad).IsRequired();
            this.Property(dp => dp.Precio).HasPrecision(9,2).IsRequired();


            this.ToTable("DetalleProforma");

            this.HasRequired(dp => dp.proforma)
                     .WithMany(prof => prof.detalleproforma)
                     .HasForeignKey(dp => dp.ProformaId)
                     .WillCascadeOnDelete(false);
        

        }
    }
}
