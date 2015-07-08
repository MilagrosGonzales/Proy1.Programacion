using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedilaSystemEntities;
using System.Data.Entity;

namespace DBMedilaRepository.Ventas
{
    public class ClienteRepository:MasterRepository,IClienteRepository
    {

        public IEnumerable<Cliente> GetAllFromClientes()
        {
            return _context.Clientes.AsEnumerable();
        }

        public Cliente GetClienteById(int id)
        {
            return _context.Clientes.Find(id);
        }

        public void AddCliente(Cliente cliente)
        {
            _context.Clientes.Add(cliente);
            _context.SaveChanges();
        }

        public void UpdateCliente(Cliente cliente)
        {
            _context.Clientes.Attach(cliente);
            _context.Entry(cliente).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void DeleteCliente(int id)
        {
            var existe = _context.Clientes.Find(id);

            if (existe != null)
            {
                _context.Clientes.Remove(existe);
                _context.SaveChanges();
            }
        }
        

        public IEnumerable<Cliente> GetClienteByCriterio(string criterio)
        {
            var query = from r in _context.Clientes
                        select r;

            if (!string.IsNullOrEmpty(criterio))
            {
                query = from r in query
                        where r.Nombre.ToUpper().Contains(criterio.ToUpper())
                        select r;
            }


            return query;
        }


        public Cliente GetClientebyDni(int dni)
        {
            var query = from c in _context.Clientes
                select c;

            if (dni!=null)
            {
                query = from p in query
                    where p.RucDni.Equals(dni)
                    select p;
            }

            return query.SingleOrDefault();
        }


        public Cliente GetClienteByRucAndDni(string dni)
        {
            var query = from c in _context.Clientes
                       where c.RucDni.Equals(dni)
                       select c;

            return query.SingleOrDefault();
        }
    }
}
