using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedilaSystemEntities;
using System.Data.Entity;

namespace DBMedilaRepository.Almacen
{
    public class ProductoRepository:MasterRepository,IProductoRepository
    {
        public IEnumerable<Producto> GetAllFromProductos()
        {
            return _context.Productos.AsEnumerable();
        }

        public Producto GetProductoById(int id)
        {
            return _context.Productos.Find(id);
        }

        public void AddProducto(Producto producto)
        {
            _context.Productos.Add(producto);
            _context.SaveChanges();
        }

        public void UpdateProducto(Producto producto)
        {
            _context.Productos.Attach(producto);
            _context.Entry(producto).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void DeleteProducto(int id)
        {
            var existe = _context.Productos.Find(id);

            if (existe != null)
            {
                _context.Productos.Remove(existe);
                _context.SaveChanges();
            }
        }


        public IEnumerable<Producto> GetProductoByCriterio(string criterio)
        {
            var query = from r in _context.Productos
                        select r;

            if (!string.IsNullOrEmpty(criterio))
            {
                query = from r in query
                        where r.Nombre.ToUpper().Contains(criterio.ToUpper())
                        select r;
            }


            return query;
        }
    }
}
