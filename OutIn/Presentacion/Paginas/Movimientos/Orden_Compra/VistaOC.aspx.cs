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
                // En este metodo se llenara el grid view, con los datos de las ordenes de pedido
                //Se llama al metodo listar ordenes de pedido y se guardan como el recurso de datos del grid view
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

        protected void btn_ingresar_click(object sender , EventArgs e)
        {
            Response.Redirect("IngresarOC.aspx");
        }
    }
}