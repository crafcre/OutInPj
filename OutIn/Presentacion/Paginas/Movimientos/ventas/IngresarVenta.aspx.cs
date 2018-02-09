using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;

namespace Presentacion.Paginas.Movimientos.ventas
{
    public partial class IngresarVenta : System.Web.UI.Page
    {
        Ventas v = new Ventas();

        protected void Page_Load(object sender, EventArgs e)
        {
            //grvproventa.DataSource = v.cargaProducto(Convert.ToInt32(txtnomproducto.Text));
        }

        protected void txtnomproducto_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btningresar_Click(object sender, EventArgs e)
        {

        }

        private void ingresaProducto()
        {
            try
            {


            }
            catch (Exception ex)
            {
                lblrta.Text = v.Rta + ex.Message;
            }


        }

        protected void grvproventa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

    /*private void Form_Load(){

   //aqui ahces la consulta

  DataGridView.DataSource = dt;  //dt es el datatable

}

 

private void btnagregar_click(){

   DataTable dt = DataGridView.DataSource as DataTable;

   DataRow row = dt.NewRow();

   row["campo1"] = textbox1.Text;

   row["campo2"] = textbox2.Text;

   dt.Rows.Add(row);

  DataGridView.DataSource = dt;

 

}

 
}*/