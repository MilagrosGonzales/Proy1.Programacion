using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedilaSystemEntities;
using DBMedilaRepository.Ventas;
using Microsoft.Practices.Unity;


namespace MedilaSystemService.Ventas
{
    public class ProformaService:IProformaService
    {
        [Dependency]
        public IProformaRepository ProformaRepository { get; set; }

        public IEnumerable<Proforma> GetAllProforma()
        {
            return ProformaRepository.GetAllProforma();
        }

        public void AddProforma(Proforma proforma)
        {
            ProformaRepository.AddProforma(proforma);
        }
    }
}
