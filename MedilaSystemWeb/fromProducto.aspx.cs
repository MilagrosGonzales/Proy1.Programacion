using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using MedilaSystemEntities;
using MedilaSystemService.Almacen;
using Microsoft.Practices.Unity;
using System.Web.ModelBinding;

namespace MedilaSystemWeb
{
    public partial class fromProducto : System.Web.UI.Page
    {
        [Dependency]

        public IProductoService productoservice { get; set; }
        [Dependency]
        public IProveedorService proveedorservice { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            var accion = Request.QueryString["accion"];
            var id = Request.QueryString["id"];

            if (accion != null && accion == "nuevo")
            {
                fvProductos.DefaultMode = FormViewMode.Insert;
            }
            else if (accion != null && id != null && accion == "delete")
            {
                var idproducto = Int32.Parse(id);

                productoservice.DeleteProducto(idproducto);


                Response.Redirect("frmListProductos.aspx");
            }

        }

        public Producto GetProducto([QueryString("id")] Int32? id)
        {
            if (id.HasValue)
                return productoservice.GetProductoById(id.Value);

            return null;
        }
        public void UpdateProducto(Producto producto)
        {
            if (ModelState.IsValid)
               productoservice.UpdateProducto(producto);
            Response.Redirect("frmListProductos.aspx");

        }

        public IEnumerable<Proveedor> GetProveedor()
        {
            return proveedorservice.GetAllFromProveedor();
        }

        public void InsertProducto(Producto producto)
        {
            if (ModelState.IsValid)
                productoservice.AddProducto(producto);
            Response.Redirect("frmListProductos.aspx");

        }
    }
}