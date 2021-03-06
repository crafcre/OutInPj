﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;

namespace Presentacion.Paginas.Productos
{
    public partial class Index : System.Web.UI.Page
    {
        Producto pr = new Producto();
        protected void Page_Load(object sender, EventArgs e)
        {
            mostrarProducto();
        }
        public void mostrarProducto()
        {
            try
            {
                //Metodo de listar productos
                // En este metodo se llenara el grid view, con los datos de los productos
                //Se llama al metodo listar productos y se guardan como el recurso de datos del grid view
                gr_Producto.DataSource = pr.listarProductos();
                gr_Producto.DataBind();
                lbl_info.Text = pr.Codigo + pr.Rta;
            }
            catch (Exception ex)
            {
                lbl_info.Text = pr.Codigo + ex.Message;
            }
        }

        protected void btn_nuevoProducto_Click(object sender, EventArgs e)
        {
            //Boton para registrar nuevo producto
            Response.Redirect("from-Producto.aspx");
        }

        protected void gr_Producto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        protected void grProducto_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Eliminar")
            {
                try
                {
                    //Boton de eliminar un proucto
                    // Se busca el id del producto a eliminar por cual boton fue el que se oprimio
                    int id = Convert.ToInt32(gr_Producto.Rows[Convert.ToInt32(e.CommandArgument)].Cells[0].Text);
                    if (pr.EliminarProducto(id))
                    {
                        lbl_info.Text = pr.Codigo + " - " + pr.Rta;
                        mostrarProducto();
                    }
                    else
                    {
                        lbl_info.Text = pr.Codigo + " - " + pr.Rta;
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