using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedilaSystemEntities;
using DBMedilaRepository.Almacen;

using Microsoft.Practices.Unity;

namespace MedilaSystemService.Almacen
{
    public class ProductoService:IProductoService
    {

         [Dependency]
        public IProductoRepository productoRepsoitory{ get; set; }

         public List<Producto> GetAllFromProductos()
         {
             return productoRepsoitory.GetAllFromProductos();
         }
        public Producto GetProductoById(int id)
        {
            return productoRepsoitory.GetProductoById(id);
        }

        public void AddProducto(Producto producto)
        {
            productoRepsoitory.AddProducto(producto);
        }

        public void UpdateProducto(Producto producto)
        {
            productoRepsoitory.UpdateProducto(producto);
        }

        public void DeleteProducto(int id)
        {
           productoRepsoitory.DeleteProducto(id);
        }


        public List<Producto> GetProductoByCriterio(string criterio)
        {
            return productoRepsoitory.GetProductoByCriterio(criterio);
        }
    }
}
