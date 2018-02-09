using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;

namespace Presentacion.Paginas.Movimientos.ventas
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        Ventas v = new Ventas();
        protected void Page_Load(object sender, EventArgs e)
        {
            //listarVenta();
        }

        private void listarVenta()
        {
          /*  
            try
            {
                grvventa.DataSource = v.listarventa();
                grvventa.DataBind();
                lbl_Info.Text = v.Rta + v.Codigo;
            }
            catch (Exception)
            {

                throw;
            }
            */
        }

        protected void grvventa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //Response.Redirect("IngresarVenta.aspx");
        }
    }
}