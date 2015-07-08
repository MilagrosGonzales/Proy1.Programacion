using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedilaSystemEntities; 

namespace DBMedilaRepository.Ventas
{
     public interface IProformaRepository
    {
        IEnumerable<Proforma> GetAllProforma();
        void AddProforma(Proforma proforma);
    }
}
