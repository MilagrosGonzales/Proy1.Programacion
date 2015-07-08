using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedilaSystemEntities;

namespace DBMedilaRepository
{
    public interface IComprobanteRepository
    {
        List<Comprobante> GetAllFromComprobante();
    }
}
