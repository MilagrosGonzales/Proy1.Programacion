using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedilaSystemEntities;
using DBMedilaRepository.Ventas;
using Microsoft.Practices.Unity;

namespace MedilaSystemService.Ventas
{
    public class ClienteService:IClienteService
    {
        [Dependency]
        public IClienteRepository _clienteRepository { get; set; }

        public IEnumerable<Cliente> GetAllFromClientes()
        {
            return _clienteRepository.GetAllFromClientes();
        }

        public IEnumerable<Cliente> GetClienteByCriterio(string criterio)
        {
            return _clienteRepository.GetClienteByCriterio(criterio);
        }

        public Cliente GetClienteById(int id)
        {
            return _clienteRepository.GetClienteById(id);
        }

        public void AddCliente(Cliente cliente)
        {
            _clienteRepository.AddCliente(cliente);
        }

        public void UpdateCliente(Cliente cliente)
        {
            _clienteRepository.UpdateCliente(cliente);
        }

        public void DeleteCliente(int id)
        {
            _clienteRepository.DeleteCliente(id);
        }


        public Cliente GetClientebyDni(int dni)
        {
            return _clienteRepository.GetClientebyDni(dni);
        }


        public Cliente GetClienteByRucAndDni(string dni)
        {
            return _clienteRepository.GetClienteByRucAndDni(dni);
        }
    }
}
