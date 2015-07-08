using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedilaSystemEntities;

namespace DBMedilaRepository.Ventas
{
    public class VentaRepository:MasterRepository,IVentaRepository
    {
        public IEnumerable<Venta> GetVentaByCriterioAndFechas(string criterio, DateTime? fechaIni, DateTime? fechaFin)
        {
            //obtengo todos los pedidos
            var query = from p in _context.Ventas
                        .Include("Cliente").Include("Comprobante")
                        //.Include("Proveedor")
                        select p;

            //filtro por cliente
            if (!string.IsNullOrEmpty(criterio))
            {
                query = from p in query
                        
                        where p.cliente.Nombre.ToUpper().Contains(criterio.ToUpper())
                        select p;
            }

            //filtro por rango de fechas ingresado
            if (fechaIni.HasValue && fechaFin.HasValue)
            {
                fechaIni = DateTime.Parse(fechaIni.Value.ToShortDateString() + " 00:00:00");
                fechaFin = DateTime.Parse(fechaFin.Value.ToShortDateString() + " 23:59:59");

                query = from p in query
                        where p.Fecha >= fechaIni && p.Fecha <= fechaFin
                        select p;
            }
            return query;
        }

        public Venta GetVentaById(int id)
        {
            var query = from p in _context.Ventas
                        .Include("Cliente")
                        //.Include("Proveedor")
                        where p.Id.Equals(id)
                        select p;
            return query.SingleOrDefault();
        }

        public void AddVenta(Venta venta)
        {
            var newVenta = new Venta();
            newVenta.clienteId = venta.clienteId;
            
            // newVenta.Cliente = venta.Cliente;
            newVenta.Fecha = venta.Fecha;
            newVenta.Total = venta.Total;
            newVenta.ComprobateId = venta.ComprobateId;
            //newVenta.TipoDocumento = venta.TipoDocumento;
            
            foreach (var item in venta.detalleVenta)
            {
                var detalle = new DetalleVenta();
                detalle.Cantidad = item.Cantidad;
                detalle.ProductoId = item.ProductoId;

                detalle.Precio = item.Precio;//TIPO DOC

                newVenta.detalleVenta.Add(detalle);
            }


            _context.Ventas.Add(newVenta);
            _context.SaveChanges();
        }

        public void UpdateVenta(Venta venta)
        {
            throw new NotImplementedException();
        }

        public void DeleteVenta(Venta id)
        {
            throw new NotImplementedException();
        }
    }
}
