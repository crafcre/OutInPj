using System;
using System.Collections.Generic;
using System.Data;
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
        List<string> lis;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Ddl_productos.DataSource = pr.listarProductos();
                Ddl_productos.DataTextField = "pd_nombre";
                Ddl_productos.DataValueField = "pd_nombre";
                Ddl_productos.DataBind();
                
            }
            lis = new List<string>();
        }
        public void llenarTable()
        {
            grvListProducto.DataSource = lis;
            grvListProducto.DataBind();
        }

       
        protected void btn_ingresar_Click(object sender, EventArgs e)
        {
            accederEmpleadoResult usu = (accederEmpleadoResult)Session["usuario"];
            DateTime MiFecha = DateTime.Today;
            dad.insertardanodev(MiFecha,Convert.ToInt32(Ddl_productos.SelectedValue),Convert.ToInt32(txt_cantidad.Text),usu.Identificacion,txt_ubicacion.Text,3, txt_descripcion.Text);
            Session["lista"] = null;
        }

        protected void btn_agregar_Click(object sender, EventArgs e)
        {
            if (Session["lista"] == null)
            {
                lis = dad.guardar(Ddl_productos.Text, txt_cantidad.Text);
                llenarTable();
            }
            else
            {
                List<string> los = (List<string>) Session["lista"];
                lis = dad.guardar(los,Ddl_productos.Text, txt_cantidad.Text);
                llenarTable();
            }
            Session["lista"] = lis;
        }
    }
}