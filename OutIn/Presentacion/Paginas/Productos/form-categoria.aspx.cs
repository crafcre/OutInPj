﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using Negocio;
using System.Web.UI.WebControls;

namespace Presentacion.Paginas.Productos
{
    public partial class form_categoria : System.Web.UI.Page
    {
        Categoria cat = new Categoria();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_ok_Click(object sender, EventArgs e)
        {
            try
            {
                cat.registraCategoria(txt_nombre.Text);
                lbl_Info.Text = cat.Codigo + cat.Rta;
                Response.Redirect("index-cat.aspx");
            }
            catch (Exception ex)
            {
                lbl_Info.Text = cat.Codigo + ex.Message;
            }
        }
    }
}