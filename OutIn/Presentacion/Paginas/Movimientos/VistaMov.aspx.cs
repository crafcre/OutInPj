using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;

namespace Presentacion.Paginas.Movimientos
{
    public partial class VistaMov : System.Web.UI.Page
    {
        Movimiento mov = new Movimiento();
        protected void Page_Load(object sender, EventArgs e)
        {
            Llenartable();
            validar();
        }


        private void validar()
        {
            switch (Session["usuario"])
            {
                case "Almacenista":
                    btnventas.Visible = false;
                    btnventas.Enabled = false;
                    break;
                case "Administrador":
                    break;
                case "Cajero":
                    btn_OC.Visible = false;
                    btn_OC.Enabled = false;
                    break;
                default:
                    break;
            }

        }

        private void Llenartable()
        {
            try
            {
                grv_Movimientos.DataSource = mov.listarMovimiento();
                grv_Movimientos.DataBind();
                lbl_Info.Text = mov.Codigo + mov.Rta;
            }
            catch (Exception ex)
            {
                lbl_Info.Text = mov.Codigo + ex.Message;
            }
        }

        protected void grv_Movimientos_RowCommand(object sender, GridViewCommandEventArgs e)
        {

        }

        protected void btn_OC_Click(object sender, EventArgs e)
        {
            Response.Redirect("Orden_Compra/VistaOC.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Paginas/Movimientos/ventas/Vistaventas.aspx");
        }
    }


    
}