using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedilaSystemEntities;

namespace MedilaSystemService.Ventas
{
    public interface IVentaService
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
