using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MedilaSystemService.Ventas;
using MedilaSystemService.Almacen;
using MedilaSystemEntities;
using Microsoft.Practices.Unity;
using System.Web.ModelBinding;

namespace MedilaSystemWeb
{
    public partial class frmProforma : System.Web.UI.Page
    {
        const string KEYPROFORMA = "proforma";
      [Dependency]
     public IProformaService ProformaService { get; set; }
      [Dependency]
      public IProductoService ProductoService { get; set; }
       [Dependency]
    public IClienteService ClienteService { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            var idProforma=Request.QueryString["id"];
            var acc = Request.QueryString["acc"];

            if (!Page.IsPostBack)
            {
                if (idProforma != "-1" && acc.Equals("editar"))
                {
                    ViewState["acc"] = "editar";

                    var id = Convert.ToInt32(idProforma);

                    var proformas = ProformaService.GetAllProforma();

                    var pro = from p in proformas
                                   where p.Id.Equals(id)
                                   select p;

                    var proforma = pro.SingleOrDefault();

                    Cache.Insert("proforma", proforma);

                    BindProforma(proforma);

                }
                else if (acc != null && acc.Equals("nuevo"))
                {
                    ViewState["acc"] = "nuevo";

                    var proforma = new Proforma() 
                    {
                        Fecha = DateTime.Now,
                       
                       
                           
                    };

                    BindProforma(proforma);

                    Cache.Insert("proforma", proforma);
                }

            }

        }

        public void BindProforma(Proforma proforma)
        {
            proforma.total = proforma.detalleproforma.Sum(i => i.Monto);
            lvDetalleProforma.DataSource = proforma.detalleproforma;
            lvProformas.DataBind();
            lvDetalleProforma.DataBind();
            
            if (proforma.detalleproforma.Count > 0)
            {
                var lblTotal = lvDetalleProforma.FindControl("lblTotalproforma") as Label;
                lblTotal.Text = proforma.total.ToString();
            }
            Cache.Insert(KEYPROFORMA, proforma);
            
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            var rucDni = txtRucDni.Text;

            var cliente = ClienteService.GetClientebyDni(int.Parse(rucDni));

            var proforma = Cache.Get(KEYPROFORMA) as Proforma;

            if (cliente == null)
            {
                //lblMsgCliente.Text = "El cliente no existe !!!";
                txtRucDni.Text = "";
                txtCliente.Text = "";
                txtTelefono.Text = "";
                //txtDireccion.Text = "";
                proforma.cliente = null;
                ScriptManager.
                                RegisterClientScriptBlock(this,
                                this.GetType(), "alertMessage", "alert('El CLIENTE no existe!!')", true);

            }
            else
            {
                proforma.ClienteId = cliente.Id;
                proforma.cliente = cliente;

                Cache.Insert(KEYPROFORMA, proforma);

                txtRucDni.Text = cliente.RucDni.ToString();
                txtCliente.Text = cliente.Nombre;
                txtTelefono.Text = cliente.Telefono;
                //txtd.Text = cliente.Direccion;
                //lblMsgCliente.Text = "";
            } 

        }

        public IEnumerable<Producto> getProductos([Control("txtCriterio")] String criterio)
        {
            return ProductoService.GetProductoByCriterio(criterio);
        }

        protected void lvProformas_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            if (e.CommandName == "agregar")
            {
                var productoId = Convert.ToInt32(e.CommandArgument.ToString());

                var producto = ProductoService.GetProductoById(productoId);

                var proforma = Cache.Get("proforma") as Proforma;

                var existe = proforma.detalleproforma.SingleOrDefault(d => d. ProductoId.Equals(productoId));

                if (existe == null)
                {
                    var detalleproforma = new DetalleProforma() 
                    {
                        ProductoId=productoId,
                        producto=producto,
                        Cantidad=1,
                        ProformaId=proforma.Id,
                        Precio=producto.PrecioUnitarioDeVenta
                    };

                    proforma.detalleproforma.Add(detalleproforma);
                }
                else
                {
                    existe.Cantidad += 1;
                }

                BindProforma(proforma);
                Cache.Insert("proforma", proforma);
            }
        }

        protected void lvDetalleProforma_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            if (e.CommandName == "quitar")
            {
                var productoId = Int32.Parse(e.CommandArgument.ToString());

                var proforma = Cache["proforma"] as Proforma;

                var item = proforma.detalleproforma.SingleOrDefault(d => d.ProductoId.Equals(productoId));

                proforma.detalleproforma.Remove(item);

                BindProforma(proforma);

                Cache.Insert("proforma", proforma);
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ViewState["acc"].ToString() == "editar")
            {
                
            }
            else if (ViewState["acc"].ToString() == "nuevo")
            {
                var proforma = Cache.Get("proforma") as Proforma;
                ProformaService.AddProforma(proforma);
                Response.Redirect("default.aspx");
            }
        }


    }
}