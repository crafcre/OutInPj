using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;

namespace Presentacion.Paginas.Productos
{
    public partial class from_Producto : System.Web.UI.Page
    {
        Producto pr = new Producto();
        Categoria cat = new Categoria();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //Carga del select de categoria
                //Se llama al metodo de listar categoria
                drl_Categoria.DataSource = cat.listarCategorias();
                drl_Categoria.DataTextField = "cat_Descripcion";
                drl_Categoria.DataValueField = "cat_Id";
                drl_Categoria.DataBind();
            }
        }

        protected void btn_Registrar_Click(object sender, EventArgs e)
        {
            try
            {
                //Se llama el metodo registrar producto y se le pasan los datos llenos
                pr.registraProducto(txt_Nombre.Text, Convert.ToInt32(txt_Cant.Text), Convert.ToDecimal(txt_Precio.Text), Convert.ToInt32(txt_Unidades.Text), Convert.ToInt32(txt_sMin.Text), Convert.ToInt32(txt_sMax.Text), txt_canXunidad.Text,Convert.ToInt32( drl_Categoria.SelectedValue));
                lbl_Info.Text = "OK";
                //Se devuelve a la lista de productos
                Response.Redirect("Index.aspx");
            }
            catch (Exception ex)
            {
                lbl_Info.Text = "Error" + ex.Message;
                throw;
            }
            
        }

        protected void drl_Categoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}