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
     public class ClienteMap:EntityTypeConfiguration<Cliente>
    {
          public ClienteMap()
          {
              
              this.HasKey(c=>c.Id);
              this.Property(c => c.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
              this.Property(c => c.TipoCliente).HasMaxLength(100).IsRequired();
              this.Property(c => c.RucDni).IsRequired();
              this.Property(c => c.Nombre).HasMaxLength(200).IsRequired();
              this.Property(c => c.Apellidos).HasMaxLength(200).IsRequired();
              this.Property(c => c.Telefono).HasMaxLength(200).IsRequired();
              this.Property(c => c.Direccion).HasMaxLength(200).IsRequired();


             this.ToTable("Cliente");

        
        
     }
    }
}
