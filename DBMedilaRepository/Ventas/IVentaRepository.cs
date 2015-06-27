using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedilaSystemEntities;

namespace DBMedilaRepository.Ventas
{
    public interface IVentaRepository
    {
        IEnumerable<Venta> GetVentaByCriterioAndFechas(string criterio,
            DateTime? fechaIni,
            DateTime? fechaFin);

        Venta GetVentaById(Int32 id);
        void AddVenta(Venta venta);
        void UpdateVenta(Venta venta);
        void DeleteVenta(Venta id);
    }
}
