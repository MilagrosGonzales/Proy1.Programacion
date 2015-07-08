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
   public class VentaMap:EntityTypeConfiguration<Venta>
    {
       public VentaMap()
       {
           this.HasKey(v=>v.Id);
            this.Property(v => v.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(v=> v.Total).HasPrecision(9,2).IsRequired();
            this.Property(v => v.Fecha)
                .HasColumnType("datetime2")
                .HasPrecision(7)
                .IsRequired();
            this.Property(v => v.HoraRegistro)
                .HasColumnType("datetime2")
                .HasPrecision(7)
                .IsOptional();
            this.Property(v => v.HoraSalida)
                .HasColumnType("datetime2")
                .HasPrecision(7)
                .IsOptional();

           this.Property(v=>v.Plazos).HasMaxLength(200).IsOptional();
           
          

             this.ToTable("Ventas");

             //this.HasRequired(v => v.proforma)
             //         .WithMany(prof=>prof.venta)
             //         .HasForeignKey(v => v.ProformaId)
             //         .WillCascadeOnDelete(false);
           this.HasRequired(v => v.cliente)
                      .WithMany(c=>c.Venta)
                      .HasForeignKey(v => v. clienteId)
                      .WillCascadeOnDelete(false);
           this.HasRequired(v =>  v.comprobante)
                     .WithMany(com => com.venta)
                     .HasForeignKey(v => v.ComprobateId)
                     .WillCascadeOnDelete(false);
       }
    }
}
