using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedilaSystemEntities;

namespace DBMedilaRepository.Ventas
{
    public interface IClienteRepository
    {
        IEnumerable<Cliente> GetAllFromClientes();
        IEnumerable<Cliente> GetClienteByCriterio(string criterio);
        Cliente GetClienteById(Int32 id);
        void AddCliente(Cliente cliente);
        void UpdateCliente(Cliente cliente);
        void DeleteCliente(Int32 id);
        Cliente GetClienteByRucAndDni(String dni);


        Cliente GetClientebyDni(Int32 dni);
    }
}
