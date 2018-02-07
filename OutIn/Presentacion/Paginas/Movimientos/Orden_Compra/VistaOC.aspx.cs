using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;

namespace Presentacion.Paginas.Movimientos.Orden_Compra
{
    public partial class VistaOC : System.Web.UI.Page
    {
        OrdenCompra oc = new OrdenCompra();
        protected void Page_Load(object sender, EventArgs e)
        {
            LLenarTable();
        }

        private void LLenarTable()
        {
            try
            {
                grv_OrdenCompra.DataSource = oc.listarOrdenCompra();
                grv_OrdenCompra.DataBind();
                lbl_Info.Text = oc.Rta + oc.Codigo;

            }
            catch (Exception ex)
            {
                lbl_Info.Text = oc.Codigo + ex.Message;
            }
          
        }

        protected void grv_OrdenCompra_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}