using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedilaSystemEntities;

namespace DBMedilaRepository.Almacen
{
    public  interface IProoveedorRepository
    {
        IEnumerable<Proveedor> GetAllFromProveedor();
        IEnumerable<Proveedor> GetProveedorByCriterio(string criterio);
        Proveedor GetProveedorById(Int32 id);
        void AddProveedor(Proveedor proveedor);
        void UpdateProveedor(Proveedor proveedor);
        void DeleteProveedor(Int32 id);
    }
}
