using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;

namespace Presentacion.Paginas.Proveedores
{
    public partial class Ingresar_Proveedores : System.Web.UI.Page
    {
        Proveedor pv = new Proveedor();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btn_Registrar_Click(object sender, EventArgs e)
        {
            try
            {
                //Se llama el metodo registrar proveedor y se le pasan los datos llenos
                pv.registraProveedor(txt_nombre.Text, txt_telefono.Text, txt_direccion.Text);
                lbl_info.Text = pv.Codigo + pv.Rta;
                //Se devuelve a la lista de proveedores
                Response.Redirect("index-proveedores.aspx");
            }
            catch (Exception ex) 
            {
                lbl_info.Text = ex.Message;
            }
        }
    }
}