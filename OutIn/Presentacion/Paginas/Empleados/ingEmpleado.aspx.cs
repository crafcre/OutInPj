using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using Negocio;
using System.Web.UI.WebControls;

namespace Presentacion.Paginas.Empleados
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        Empleado emp = new Empleado();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (dr_Cargo.Text == "")
            {
                //Se llenan los drop down list con los datos de cargo y tipo de documento
                dr_TipoId.Items.Add("C.C.");
                dr_TipoId.Items.Add("C.E.");
                dr_Cargo.Items.Add("Administrador");
                dr_Cargo.Items.Add("Cajero");
                dr_Cargo.Items.Add("Almacenista");
            }
            
        }

        protected void btn_Registrar_Click(object sender, EventArgs e)
        {
            try
            {
                //Se llama el metodo registrar empleado y se le pasan los datos llenos
                emp.registraEmpleado(txt_Id.Text, fec_Nacimiento.SelectedDate, txt_Nombre.Text, txt_contrasena.Text, dr_TipoId.Text, txt_Direccion.Text, dr_Cargo.Text, txt_telefono.Text);
                lbl_info.Text = "OK";
                //Se redirige a el index del empleado
                Response.Redirect("Index.aspx");
            }
            catch (Exception ex)
            {
                lbl_info.Text = "Error" + ex.Message;
                throw;
            }
            
        }

        protected void dr_TipoId_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}