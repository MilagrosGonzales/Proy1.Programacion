using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using MedilaSystemEntities;
using MedilaSystemService.Ventas;
using Microsoft.Practices.Unity;
using System.Web.ModelBinding;


namespace MedilaSystemWeb
{
    public partial class frmCliente : System.Web.UI.Page
    {
        [Dependency]
        public IClienteService clienteservice { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            var accion = Request.QueryString["accion"];
            var id = Request.QueryString["id"];

            if (accion != null && accion == "nuevo")
            {
                fvCliente.DefaultMode = FormViewMode.Insert;
            }
            else if (accion != null && id != null && accion == "delete")
            {
                var idcliente = Int32.Parse(id);

                clienteservice.DeleteCliente(idcliente);
                


                Response.Redirect("frmListClientes.aspx");
            }

        }

        public Cliente GetCliente([QueryString("id")] Int32? id)
        {
            if (id.HasValue)
                return clienteservice.GetClienteById(id.Value);

            return null;
        }
        public void UpdateCliente(Cliente cliente)
        {
            if (ModelState.IsValid)
               clienteservice.UpdateCliente(cliente);
            Response.Redirect("frmListClientes.aspx");

        }


        public void InsertCliente(Cliente cliente)
        {
            

            if (ModelState.IsValid)
                clienteservice.AddCliente(cliente);
            Response.Redirect("frmListClientes.aspx");


        }

        
           
    }
}