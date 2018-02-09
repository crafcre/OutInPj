using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using OutInDB;

namespace Presentacion.Paginas.Movimientos.Dano_Devolucion
{    
    public partial class Dano_Devolucion : System.Web.UI.Page
    {
        Dan_Devolucion dad = new Dan_Devolucion();
        Producto pr = new Producto();
        protected void Page_Load(object sender, EventArgs e)
        {
            Ddl_productos.DataSource = pr.listarProductos();
            Ddl_productos.DataTextField = "pd_nombre";
            Ddl_productos.DataValueField = "pd_IdProducto";
            Ddl_productos.DataBind();
        }

        protected void btn_ingresar_Click(object sender, EventArgs e)
        {
            accederEmpleadoResult usu = (accederEmpleadoResult)Session["usuario"];
            DateTime MiFecha = DateTime.Today;
            dad.insertardanodev(MiFecha,Convert.ToInt32(Ddl_productos.SelectedValue),Convert.ToInt32(txt_cantidad.Text),usu.Identificacion,txt_ubicacion.Text,3, txt_descripcion.Text);
        }
    }
}