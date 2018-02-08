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
        protected void Page_Load(object sender, EventArgs e)
        {
            listarVenta();
        }

        private void listarVenta()
        {
            Ventas venta = new Ventas();
            try
            {/*
                grvventa.DataSource = venta.listarventa();
                grvventa.DataBind();
                lbl_Info.Text = venta.Rta + venta.Codigo;*/
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}