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
    public  class ComprobanteMap:EntityTypeConfiguration<Comprobante>
    {
        public ComprobanteMap()
        {
            this.HasKey(com => com.Id);
            this.Property(com => com.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(com => com.TipoComprobante).HasMaxLength(100).IsRequired();
            this.Property(com => com.IGV).HasPrecision(18,2).IsRequired();


            this.ToTable("Comprobante");

            
        }
    }
}
