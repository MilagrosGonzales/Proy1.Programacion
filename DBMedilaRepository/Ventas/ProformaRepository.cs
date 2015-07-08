using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedilaSystemEntities;
using System.Data.Entity;
namespace DBMedilaRepository.Ventas
{
     public class ProformaRepository:MasterRepository,IProformaRepository
    {
        public IEnumerable<Proforma> GetAllProforma()
         {
             var query = from p in _context.Proformas.Include("cliente").Include("producto").Include("detalleproforma")
                         select p;

             return query;
        }

        public void AddProforma(Proforma proforma)
        {
            var newProforma = new Proforma();
            newProforma.ClienteId = proforma.ClienteId;

            // newVenta.Cliente = venta.Cliente;
            newProforma.Fecha = proforma.Fecha;
            newProforma.total = proforma.total;

            //newVenta.TipoDocumento = venta.TipoDocumento;

            foreach (var item in proforma.detalleproforma)
            {
                var detalle = new DetalleProforma();
                detalle.Cantidad = item.Cantidad;
                detalle.ProductoId = item.ProductoId;

                detalle.Precio = item.Precio;
                //TIPO DOC

                newProforma.detalleproforma.Add(detalle);
            }


            _context.Proformas.Add(newProforma);
            _context.SaveChanges();
        }
        }
    }

