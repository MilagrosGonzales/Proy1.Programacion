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
    public partial class frmListVentas : System.Web.UI.Page
    {
       [Dependency]
        public IVentaService VentaService { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IEnumerable<Venta>
            GetVentas([Control("txtCriterio")]string criterio,
                       [Control("txtFechaIni")]DateTime? fechaIni,
                       [Control("txtFechaFin")]DateTime? fechaFin)
        {
            return VentaService.GetVentaByCriterioAndFechas(criterio, fechaIni, fechaFin);
                
        }
    }
}