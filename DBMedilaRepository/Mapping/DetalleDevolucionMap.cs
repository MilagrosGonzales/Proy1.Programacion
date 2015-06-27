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
    class DetalleDevolucionMap:EntityTypeConfiguration<DetalleDeDevolucion>
    {
        public DetalleDevolucionMap()
        {
            this.HasKey(dd => new { dd. item, dd.hojaDevolucionId });

            this.Property(dd => dd.item)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(dd => dd.hojaDevolucionId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(dd => dd.ProductoId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.ToTable("DetalleDevolucion");
          

            this.HasRequired(dd => dd.producto)
                .WithMany(dd => dd.detallehojaDevolucion)
                .HasForeignKey(p => p.ProductoId)
                .WillCascadeOnDelete(false);
            this.HasRequired(dd => dd.hojaDevolucion)
                .WithMany(dd => dd.DetalleDevolucion)
                .HasForeignKey(hd =>hd.hojaDevolucionId)
                .WillCascadeOnDelete(false);
        }
    }
}
