using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using OutInDB;


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
                // se llena el drop down list con los productos disponibles
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
                // Llamar variable de session mencionando que tipo de dato es y guardandolo en una
                // variable local del mismo tipo y usarla localmente
                accederEmpleadoResult usu = (accederEmpleadoResult)Session["usuario"];
                DateTime MiFecha = DateTime.Today;
                //Se llama el metodo registrar orden de compra y se le pasan los datos llenos
                oc.registrarOc(MiFecha, Convert.ToInt32(dl_Productos.SelectedValue), Convert.ToInt32(txt_cant.Text), usu.Identificacion, txt_ubicacion.Text, 1, Convert.ToDecimal(txt_precio.Text));
                lbl_info.Text = "OK";
                //Se devuelve a la lista de orden de compra
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