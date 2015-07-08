using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedilaSystemEntities;

namespace DBMedilaRepository
{
    public class ComprobanteRepository : MasterRepository, IComprobanteRepository
    {
        public List<Comprobante> GetAllFromComprobante()
        {
            var query = from p in _context.Comprobante
                select p;
            return query.ToList();
        }
    }
}
