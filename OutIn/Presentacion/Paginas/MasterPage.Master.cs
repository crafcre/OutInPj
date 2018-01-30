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
            Response.Redirect("../../Login.aspx");
        }

        protected void btn_Productos_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Productos/Index.aspx");
        }

        protected void btn_cat_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Productos/index-cat.aspx");
        }
    }
}