﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedilaSystemEntities;

namespace MedilaSystemService.Almacen
{
     public interface IProductoService
    {
        IEnumerable<Producto> GetAllFromProductos();
        IEnumerable<Producto> GetProductoByCriterio(string criterio); 
        Producto GetProductoById(Int32 id);
        void AddProducto(Producto producto);
        void UpdateProducto(Producto producto);
        void DeleteProducto(Int32 id);
    }
}
