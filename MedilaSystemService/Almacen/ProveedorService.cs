using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBMedilaRepository.Almacen;
using MedilaSystemEntities;


using Microsoft.Practices.Unity;

namespace MedilaSystemService.Almacen
{
 
     public class ProveedorService:IProveedorService
    {

        [Dependency]
        public IProoveedorRepository proveedorRepostory { get; set; }

        public IEnumerable<Proveedor> GetAllFromProveedor()
        {
            return proveedorRepostory.GetAllFromProveedor();

        }
         public IEnumerable<Proveedor> GetProveedorByCriterio(string criterio)
        {
            return  proveedorRepostory.GetProveedorByCriterio(criterio);
        }

        public Proveedor GetProveedorById(int id)
        {
            return proveedorRepostory.GetProveedorById(id);
        }

        public void AddProveedor(Proveedor proveedor)
        {
            proveedorRepostory.AddProveedor(proveedor);
        }

        public void UpdateProveedor(Proveedor proveedor)
        {
            proveedorRepostory.UpdateProveedor(proveedor);
        }

        public void DeleteProveedor(int id)
        {
            proveedorRepostory.DeleteProveedor(id);
        }
      }
    }

