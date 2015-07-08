using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBMedilaRepository;
using MedilaSystemEntities;
using Microsoft.Practices.Unity;

namespace MedilaSystemService
{
    public class ComprobanteService : IComprobanteService
    {
        [Dependency]
        public IComprobanteRepository comproRepo { get; set; }
        public List<Comprobante> GetAllFromComprobante()
        {
            return comproRepo.GetAllFromComprobante();
        }
    }
}
