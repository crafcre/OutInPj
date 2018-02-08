using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;

namespace Presentacion.Paginas.Movimientos.Orden_Compra
{
    public partial class IngresarOC : System.Web.UI.Page
    {
        OrdenCompra oc = new OrdenCompra();
        Producto pr = new Producto();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                dl_Productos.DataSource = pr.listarProductos();
                dl_Productos.DataTextField = "pd_nombre";
                dl_Productos.DataValueField = "pd_IdProducto";
                dl_Productos.DataBind();
            }
        }

       
        protected void dl_Productos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnIng_click(object sender, EventArgs e)
        {

            try
            {
                DateTime MiFecha = DateTime.Today;
                oc.registrarOc(MiFecha, Convert.ToInt32(dl_Productos.SelectedValue), Convert.ToInt32(txt_cant.Text), Session["id"].ToString(), txt_ubicacion.Text, 1, Convert.ToDecimal(txt_precio.Text));
                lbl_info.Text = "OK";
                Response.Redirect("VistaOC.aspx");
            }
            catch (Exception ex)
            {
                lbl_info.Text = "Error" + ex.Message;
                throw;
            }

        }
    }
}