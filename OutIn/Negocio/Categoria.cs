using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OutInDB;

namespace Negocio
{
    public class Categoria:Respuesta
    {
        OutInDBDataContext datos = new OutInDBDataContext();

        // ------------------------------------------------------


        public List<listarCatgoriaResult> listarCategorias()
        {// mostrar un listado de las categorias
            try
            {
                List<listarCatgoriaResult> lisCategoria = datos.listarCatgoria().ToList();
                Codigo = "OK";
                Rta = "Se realizo correctamente";
                return lisCategoria;
            }
            catch (Exception ex)
            {
                Codigo = "Error";
                Rta = ex.Message;
                return null;
            }
        }
        public bool registraCategoria(string nombre)
        {// registrar una categoria a la base de datos
            try
            {            
                datos.crearCatgoria(nombre);
                return true;
            }
            catch (Exception ex)
            {
                Rta = ex.Message;
                return false;
            }
        }
        public bool EliminarCategoria(int id)
        {
            try
            {
                datos.eliminarCategoria(id);
                Codigo = "OK";
                Rta = "Se Eliminó el contacto correctamente";
                return true;
            }
            catch (Exception EX)
            {
                Codigo = "Error";
                Rta = EX.Message;
                return false;
            }

        }
    }
}
