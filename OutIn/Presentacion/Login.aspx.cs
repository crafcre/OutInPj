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
        {// control de sessiones abiertas
            //variable de session es usuario donde se guardara el resultado de una consulta de login.
            if (Session["usuario"] != null)
            {
                //Si la variable de session usuario esta llena se redirigira
                //a la pantalla de inicio de la aplicacion
                Response.Redirect("Paginas/Empleados/Index.aspx");
            }
        }

        protected void btn_Ingresar_Click(object sender, EventArgs e)
        {
            try
            {
                //Se instancia un controlador de empleado 
                Empleado em = new Empleado();
                //Se llama al metodo de ingresar pasandole el usuario y la contraseña
                //Al realizar la consulta si hay coincidencias devolvera un true 
                if (em.ingresar(txt_usuario.Text, txt_contrasena.Text) != null)
                {
                    // Se crea un usuario desde la respuesta de la consulta
                    accederEmpleadoResult usuario = em.ingresar(txt_usuario.Text, txt_contrasena.Text);
                    // Se crea la variable de session usuario y se llena con el usuario consultado
                    //Se envian los mensajes al usuario y se redirecciona a la ventana inicail
                    Session["usuario"] = usuario;           
                    
                    lbl_info.Text = "Accediste Correctamente " + usuario.Nombre;
                    lbl_info.Visible = true;                 
                    Response.Redirect("Paginas/Empleados/Index.aspx");

                }
                else
                {
                    //Si las credenciales son erroneas se le envia un mensaje de error al usuario
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