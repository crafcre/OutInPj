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
    }
}