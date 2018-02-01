using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OutInDB;

namespace Negocio
{
    public class Proveedor:Respuesta
    {
        OutInDBDataContext datos = new OutInDBDataContext();

        // ------------------------------------------------------


        public List<listarProveedorResult> listarProveedores()
        {// mostrar un listado de los proveedores
            try
            {
                List<listarProveedorResult> lisProveedor = datos.listarProveedor().ToList();
                Codigo = "OK";
                Rta = "Se realizo correctamente";
                return lisProveedor;
            }
            catch (Exception ex)
            {
                Codigo = "Error";
                Rta = ex.Message;
                return null;
            }
        }
        public bool registraProveedor(string nombre, string contacto, string direccion)
        {// registrar un proveedor a la base de datos
            try
            {
                datos.InsertarProveedor(nombre, contacto,direccion );
                return true;
            }
            catch (Exception ex)
            {
                Rta = ex.Message;
                return false;
            }
        }
        public bool EliminarProveedor(int id)
        {
            try
            {
                datos.eliminarProveedor(id);
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
