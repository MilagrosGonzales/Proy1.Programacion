using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using MedilaSystemService.Ventas;
using MedilaSystemEntities;
using Microsoft.Practices.Unity;
using System.Web.ModelBinding;


namespace MedilaSystemWeb
{
    public partial class frmListClientes : System.Web.UI.Page
    {
        [Dependency]
        public IClienteService clienteservice { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public IEnumerable<Cliente> Getcliente([Control("txtcriterio")]string criterio)
        {
            return clienteservice.GetClienteByCriterio(criterio);
        }
    }
}