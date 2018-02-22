using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;

namespace Presentacion.Paginas.Proveedores
{
    public partial class index_proveedores : System.Web.UI.Page
    {
        Proveedor pv = new Proveedor();

        protected void Page_Load(object sender, EventArgs e)
        {
            llenarTable();
        }
        
        public void llenarTable()
        {
            try
            {
                // En este metodo se llenara el grid view, con los datos de los proveedores
                //Se llama al metodo listar proveedores y se guardan como el recurso de datos del grid view
                gv_proveedores.DataSource = pv.listarProveedores();
                gv_proveedores.DataBind();
                lbl_info.Text = pv.Codigo + pv.Rta;
            }
            catch (Exception ex)
            {
                lbl_info.Text = pv.Codigo + ex.Message;
            }
        }
         protected void gv_proveedores_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Eliminar")
            {
                try
                {
                    //Boton de eliminar un proveedor
                    // Se busca el id del proveedor a eliminar por cual boton fue el que se oprimio
                    int id = Convert.ToInt32(gv_proveedores.Rows[Convert.ToInt32(e.CommandArgument)].Cells[0].Text);
                    //Se llama al metodo de eliminar proveedor pasandole el id
                    //Si se borra correctamente el metodo devolvera true 
                    if (pv.EliminarProveedor(id))
                    {
                        lbl_info.Text = pv.Codigo + " - " + pv.Rta;
                        llenarTable();
                    }
                    else
                    {
                        lbl_info.Text = pv.Codigo + " - " + pv.Rta;
                    }
                }
                catch (Exception Ex)
                {
                    lbl_info.Text = Ex.Message;
                }
            }
            else if (e.CommandName == "Editar")
            {

            }
        }

        protected void gv_proveedores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btn_nuevo_proveedor_Click(object sender, EventArgs e)
        {
            //Boton de ingresar proveedor nuevo
            Response.Redirect("ingresar_Proveedores.aspx");
        }
    }
}