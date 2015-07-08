using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MedilaSystemService.Almacen;
using MedilaSystemEntities;
using Microsoft.Practices.Unity;
using System.Web.ModelBinding;


namespace MedilaSystemWeb
{
    public partial class frmListProductos : System.Web.UI.Page
    {
        [Dependency]
        public IProductoService productoService { get; set; }
        [Dependency]
        public IProveedorService provvedorservice { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public IEnumerable<Producto> Getproducto([Control("txtcriterio")]string criterio)
        {
            return productoService.GetProductoByCriterio(criterio);
        }

       /* public IEnumerable<Producto> Getproducto()
        {
            return productoService.GetAllFromProductos();
        }*/
    }
}