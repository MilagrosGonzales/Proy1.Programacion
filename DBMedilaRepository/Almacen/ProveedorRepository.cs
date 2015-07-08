using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedilaSystemEntities;
using MedilaSystemEntities;
using System.Data.Entity;

namespace DBMedilaRepository.Almacen
{
    public class ProveedorRepository:MasterRepository,IProoveedorRepository
    {
        public IEnumerable<Proveedor> GetAllFromProveedor()
        {
            return _context.Proveedores.AsEnumerable();
        }


        public IEnumerable<Proveedor> GetProveedorByCriterio(string criterio)
        {
            var query = from r in _context.Proveedores
                        select r;

            if (!string.IsNullOrEmpty(criterio))
            {
                query = from r in query
                        where r.Ruc.ToUpper().Contains(criterio.ToUpper())
                      
                        select r;
            }


            return query;
        }

        public Proveedor GetProveedorById(int id)
        {
            return _context.Proveedores.Find(id);
        }

        public void AddProveedor(Proveedor proveedor)
        {
           _context.Proveedores.Add(proveedor);
           _context.SaveChanges();
        }

        public void UpdateProveedor(Proveedor proveedor)
        {
            _context.Entry(proveedor).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void DeleteProveedor(int id)
        {
            var existe = _context.Proveedores.Find(id);

            if (existe != null)
            {
                _context.Proveedores.Remove(existe);
                _context.SaveChanges();
            }
        }
    }
}
