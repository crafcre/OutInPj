using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentacion
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuario"] == null)
            {
                Response.Redirect("../../Login.aspx");
                
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["usuario"] = null;
            Response.Redirect("~/Login.aspx");
        }

        protected void btn_Productos_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Paginas/Productos/Index.aspx");
        }

        protected void btn_cat_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Paginas/Productos/index-cat.aspx");
        }

        protected void btn_pv_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Paginas/Proveedores/index-proveedores.aspx");
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            Response.Redirect("~/Paginas/Movimientos/VistaMov.aspx");
        }

    }
}