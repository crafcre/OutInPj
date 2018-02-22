using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OutInDB;

namespace Negocio
{
    public class Producto:Respuesta
    {
        OutInDBDataContext datos = new OutInDBDataContext();

        // ------------------------------------------------------
        public bool sumarProducto(int id, int cant)
        {
            try
            {
                datos.sumarProducto(id, cant);
                return true;
            }
            catch (Exception EX)
            {
                Codigo = "Error";
                Rta = EX.Message;
                return false;
            }
            
        }

        public List<listarProductosResult> listarProductos()
        {// mostrar un listado de las categorias
            try
            {
                List<listarProductosResult> lisProductos = datos.listarProductos().ToList();
                Codigo = "OK";
                Rta = "Se realizo correctamente";
                return lisProductos;
            }
            catch (Exception ex)
            {
                Codigo = "Error";
                Rta = ex.Message;
                return null;
            }
        }
        public bool registraProducto(string nombre, int cant,decimal precio, int unidades, int sMin, int sMax, string cantXuni, int cat)
        {// registrar un producto a la base de datos
            try
            {
                /*
                int c = 0;
                switch (cat)
                {
                    case "Cereales":
                        c = 1;
                        break;
                    default:
                        break;
                }*/
                datos.crearProducto(nombre,cant,precio,unidades,sMin,sMax,cantXuni,cat);
                return true;
            }
            catch (Exception ex)
            {
                Rta = ex.Message;
                return false;
            }
        }
        public bool EliminarProducto(int id)
        {
            try
            {
                datos.eliminarProducto(id);
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

