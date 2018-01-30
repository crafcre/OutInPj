using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;

namespace Presentacion.Paginas.Productos
{
    public partial class index_cat : System.Web.UI.Page
    {
        Categoria cat = new Categoria();
        protected void Page_Load(object sender, EventArgs e)
        {
            llenarTabla();
        }
        public void llenarTabla()
        {
            try
            {
                gr_cat.DataSource = cat.listarCategorias();
                gr_cat.DataBind();
                lbl_info.Text = cat.Codigo + cat.Rta;
            }
            catch (Exception ex)
            {
                lbl_info.Text = cat.Codigo + ex.Message;
            }
        }

        protected void btn_catNueva_Click(object sender, EventArgs e)
        {
            Response.Redirect("form-categoria.aspx");
        }

        protected void gr_cat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void gr_cat_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Eliminar")
            {
                try
                {

                    int id = Convert.ToInt32(gr_cat.Rows[Convert.ToInt32(e.CommandArgument)].Cells[0].Text);
                    if (cat.EliminarCategoria(id))
                    {
                        lbl_info.Text = cat.Codigo + " - " + cat.Rta;
                        llenarTabla();
                    }
                    else
                    {
                        lbl_info.Text = cat.Codigo + " - " + cat.Rta;
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
    }
}