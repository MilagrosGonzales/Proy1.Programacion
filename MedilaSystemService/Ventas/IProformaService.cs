using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedilaSystemEntities;

namespace MedilaSystemService.Ventas
{
    public interface IProformaService
    {
        void AddProforma(Proforma proforma);
        IEnumerable<Proforma> GetAllProforma();
    }
}
