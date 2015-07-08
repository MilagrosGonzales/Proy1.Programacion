using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedilaSystemEntities;

namespace MedilaSystemService.Ventas
{
    public interface IClienteService
    {
        IEnumerable<Cliente> GetAllFromClientes();
        IEnumerable<Cliente> GetClienteByCriterio(string criterio);
        Cliente GetClienteById(Int32 id);
        void AddCliente(Cliente cliente);
        void UpdateCliente(Cliente cliente);
        void DeleteCliente(Int32 id);

        Cliente GetClientebyDni(Int32 dni);
        Cliente GetClienteByRucAndDni(String dni);
   
    }
}
