using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;

namespace Presentacion.Paginas
{
    public partial class Index : System.Web.UI.Page
    {
        Empleado emp = new Empleado();
        protected void Page_Load(object sender, EventArgs e)
        {
            Llenartable();
        }
        public void Llenartable()
        {
            try
            {
                // En este metodo se llenara el grid view, con los datos de los empleados
                //Se llama al metodo listar empleados y se guardan como el recurso de datos del grid view
                gv_Empleados.DataSource = emp.listarEmpleado();
                gv_Empleados.DataBind();
                lbl_info.Text = emp.Codigo + emp.Rta;
            }
            catch (Exception ex)
            {
                lbl_info.Text = emp.Codigo + ex.Message;
            }
        }

        protected void gv_Empleados_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("ingEmpleado.aspx");
        }


        // probar el boton de eliminar


        protected void Gv_Empleados_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Eliminar")
            {
                try
                {
                    //Boton de eliminar un empleado
                    // Se busca el id del empleado a eliminar por cual boton fue el que se oprimio
                    string id = gv_Empleados.Rows[Convert.ToInt32(e.CommandArgument)].Cells[0].Text;
                    //Se llama al metodo de eliminar empleado pasandole el id
                    //Si se borra correctamente el metodo devolvera true 
                    if (emp.EliminarEmpleado(id))
                    {
                        lbl_info.Text = emp.Codigo + " - " + emp.Rta;
                        Llenartable();
                    }
                    else
                    {
                        lbl_info.Text = emp.Codigo + " - " + emp.Rta;
                    }
                }
                catch (Exception Ex)
                {
                    lbl_info.Text = Ex.Message;
                }
            }
            else if(e.CommandName == "Editar")
            {

            }
        }
    }
}