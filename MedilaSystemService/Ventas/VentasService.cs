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
    public class VentasService:IVentaService
    {
        [Dependency]
        public IVentaRepository VentaRepository { get; set; }

        public IEnumerable<Venta> GetVentaByCriterioAndFechas(string criterio, DateTime? fechaIni, DateTime? fechaFin)
        {
            return VentaRepository.GetVentaByCriterioAndFechas(criterio, fechaIni, fechaFin);
        }

        public Venta GetVentaById(int id)
        {
            return VentaRepository.GetVentaById(id);
        }

        public void AddVenta(Venta venta)
        {
            VentaRepository.AddVenta(venta);
        }

        public void UpdateVenta(Venta venta)
        {
            VentaRepository.UpdateVenta(venta);
        }

        public void DeleteVenta(Venta id)
        {
            VentaRepository.DeleteVenta(id);
        }
    }
}
