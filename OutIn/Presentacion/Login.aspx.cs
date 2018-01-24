using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using OutInDB;

namespace Presentacion
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuario"] != null)
            {
                Response.Redirect("Paginas/Index.aspx");
            }
        }

        protected void btn_Ingresar_Click(object sender, EventArgs e)
        {
            try
            {
                Empleado em = new Empleado();
                if (em.ingresar(txt_usuario.Text,txt_contrasena.Text) != null)
                {
                    accederEmpleadoResult usuario = em.ingresar(txt_usuario.Text, txt_contrasena.Text);
                    Session["usuario"] = usuario;
                    lbl_info.Text = "Accediste Correctamente " + usuario.Nombre;
                    lbl_info.Visible = true;
                    Response.Redirect("Paginas/Index.aspx");
                }
                else
                {
                    lbl_info.Text = "Error de Credenciales Intentalo Nuevamente";
                    lbl_info.Visible = true;
                }
            }
            catch (Exception ex)
            {
                lbl_info.Text = "ERROR " + ex.Message;
                lbl_info.Visible = true;
            }
        }
    }
}