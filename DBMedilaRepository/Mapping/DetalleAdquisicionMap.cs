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
    public  class DetalleAdquisicionMap:EntityTypeConfiguration<DetalleAdquisicion>
    {
        public DetalleAdquisicionMap()
        {
            this.HasKey(da => new { da. item, da.adquisicionId });

            this.Property(da => da.item)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(da => da.adquisicionId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(da => da.ProductoId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.ToTable("DetalleAdquisicion");
          

            this.HasRequired(da => da.producto)
                .WithMany(da => da.detalleadquisicion)
                .HasForeignKey(p => p.ProductoId)
                .WillCascadeOnDelete(false);
            this.HasRequired(da => da.adquisicion)
                .WithMany(da => da.DetalleAdquisicion)
                .HasForeignKey(a => a.adquisicionId)
                .WillCascadeOnDelete(false);
        }
    }
}
