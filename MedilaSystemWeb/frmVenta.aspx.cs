using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MedilaSystemEntities;
using MedilaSystemService;
using Microsoft.Practices.Unity;
using MedilaSystemService.Ventas;
using MedilaSystemService.Almacen;
using System.Web.ModelBinding;

namespace MedilaSystemWeb
{
    public partial class frmVenta : System.Web.UI.Page
    {
        private const string KEYVENTA = "venta";
        [Dependency]
        public IVentaService VentaService { get; set; }
        [Dependency]
        public IClienteService clienteService { get; set; }
        [Dependency]
        public IProductoService ProductoService { get; set; }
        [Dependency]
        public IComprobanteService comproService { get; set; }
        

        protected void Page_Load(object sender, EventArgs e)
        {
            var idVenta = Request.QueryString["IdVenta"];
            var opc = Request.QueryString["opc"];

            if (!Page.IsPostBack)
            {
                if (idVenta != null && opc.Equals("editar"))
                {
                    ViewState["opc"] = "editar";

                    var id = Int32.Parse(idVenta.ToString());

                    var venta = VentaService.GetVentaById(id);

                    Cache.Insert("venta", venta);

                    BindVenta(venta);
                }
                else if (opc != null && opc=="nuevo")
                {
                    var nuevaenta = new Venta()
                    {
                        Fecha = DateTime.Now
                    };
                    BindVenta(nuevaenta);

                    ViewState["opc"] = opc;
                }

            }
        }
        private void BindVenta(Venta venta)
        {
            hfIdVenta.Value = venta.Id.ToString();

            if (venta.cliente !=null)
            {
                txtCliente.Text = venta.cliente.Nombre.ToString();
                txtDireccion.Text = venta.cliente.Direccion.ToString();
                txtDni.Text = venta.cliente.RucDni.ToString();
            }
            
            txtHoraPedido.Text = venta.Fecha.ToLongTimeString();
            
            txtFecha.Text = venta.Fecha.ToShortDateString();

            venta.Total = venta.detalleVenta.Sum(i => i.Monto);

            lvDetalleVenta.DataSource = venta.detalleVenta;
            lvDetalleVenta.DataBind();

            if (venta.detalleVenta.Count > 0)
            {
                var lblTotal = lvDetalleVenta.FindControl("lblTotal") as Label;
                lblTotal.Text = venta.Total.ToString();
            }
            Cache.Insert(KEYVENTA,venta);
        }

        private Venta GetVenta()
        {
            return Cache.Get(KEYVENTA) as Venta;
        }

        public IQueryable<Producto> GetProductos([Control("txtCriterio")] string criterio)
        {
            return ProductoService.GetProductoByCriterio(criterio).AsQueryable();
        }

        public void LoadData()
        {
            var criterio = txtCliente.Text;

            ProductoService.GetProductoByCriterio(criterio);
        }

        protected void lvProductos_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            if (e.CommandName == "addProducto")
            {
                var productoId = Int32.Parse(e.CommandArgument.ToString());

                var producto = ProductoService.GetProductoById(productoId);

                var venta = GetVenta();

                var existe = venta.detalleVenta
                    .SingleOrDefault(i => i.ProductoId.Equals(productoId));

                if (existe == null)
                {
                    var itemPedido = new DetalleVenta()
                    {
                        VentaId = venta.Id,
                        Cantidad = 1,
                        producto = producto,
                        ProductoId = productoId,
                        Precio = producto.PrecioUnitarioDeVenta
                    };
                    venta.detalleVenta.Add(itemPedido);
                }
                else
                {
                    existe.Cantidad += 1;
                }

                BindVenta(venta);

                Cache.Insert("venta", venta);

            }
        }

        protected void txtBuscarClienteDNI_Click(object sender, EventArgs e)
        {
            var rucDni = txtDni.Text;

            var cliente = clienteService.GetClientebyDni(int.Parse(rucDni));

            var venta = Cache.Get(KEYVENTA) as Venta;

            if (cliente == null)
            {
                //lblMsgCliente.Text = "El cliente no existe !!!";
                txtDni.Text = "";
                txtCliente.Text = "";
                txtDireccion.Text = "";
                venta.cliente = null;
                ScriptManager.
                                RegisterClientScriptBlock(this,
                                this.GetType(), "alertMessage", "alert('El CLIENTE no existe!!')", true);

            }
            else
            {
                venta.clienteId = cliente.Id;
                venta.cliente = cliente;

                Cache.Insert(KEYVENTA, venta);

                txtDni.Text = cliente.RucDni.ToString();
                txtCliente.Text = cliente.Nombre;
                txtDireccion.Text = cliente.Direccion;
                //lblMsgCliente.Text = "";
            } 
        }

        protected void lvDetalleVenta_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            if (e.CommandName == "QuitarDetalle")
            {
                var productoId = Int32.Parse(e.CommandArgument.ToString());

                var venta = Cache.Get("venta") as Venta;

                var item = venta.detalleVenta.SingleOrDefault(i => i.ProductoId.Equals(productoId));

                venta.detalleVenta.Remove(item);

                BindVenta(venta);

                Cache.Insert("venta", venta);
            }
        }

        public IEnumerable<Comprobante> GetComprobantes()
        {
            return comproService.GetAllFromComprobante();
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            var venta = GetVenta();

            venta.Fecha = DateTime.Parse(txtFecha.Text);
            


            if (venta != null)
            {
                if (ViewState["opc"].ToString() == "nuevo")
                {
                    if (txtCliente.Text == "" && txtDni.Text == "")
                    {
                        ScriptManager.
                                RegisterClientScriptBlock(this,
                                this.GetType(), "alertMessage", "alert('Llenar datos de Cliente..!!')", true);
                    }
                    else
                    {



                        venta.ComprobateId = Int32.Parse(cbTipoComprobante.SelectedValue);
                        VentaService.AddVenta(venta);
                        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('VENTA Registrada..!!')", true);
                        Response.Redirect("frmListVentas.aspx");
                    }
                }
                else if (ViewState["opc"].ToString() == "editar")
                {
                    if (txtCliente.Text == "" && txtDni.Text == "")
                    {
                        ScriptManager.
                            RegisterClientScriptBlock(this,
                                this.GetType(), "alertMessage", "alert('Llenar datos de Cliente..!!')", true);
                    }
                    else
                    {
                        venta.ComprobateId = Int32.Parse(cbTipoComprobante.SelectedValue);
                        VentaService.UpdateVenta(venta);
                        ScriptManager.
                            RegisterClientScriptBlock(this,
                                this.GetType(), "alertMessage", "alert('Venta Editada..!!')", true);
                        Response.Redirect("frmListVentas.aspx");
                    }
                }
            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            LoadData();
        }

    }
}



    
