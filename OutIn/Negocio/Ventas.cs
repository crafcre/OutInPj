using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OutInDB;

namespace Negocio
{
   public class Ventas:Movimiento
    {
        OutInDBDataContext datos = new OutInDBDataContext();
        
        public List<listarventaResult> listarventa()
        {
            try
            {
                List<listarventaResult> listV = datos.listarventa().ToList();
                Codigo = "OK";
                Rta = "Se realizo correctamente";
                return listV;
            }
            catch (Exception ex)
            {

                Codigo = "Error";
                Rta = ex.Message;
                return null;
            }
            

        } 
    }
}
/*  public List<listarOrdenCompraResult> listarOrdenCompra()
        {// mostrar un listado de los empleados
            try
            {
                List<listarOrdenCompraResult> lisOC = datos.listarOrdenCompra().ToList();
                Codigo = "OK";
                Rta = "Se realizo correctamente";
                return lisOC;
            }
            catch (Exception ex)
            {
                Codigo = "Error";
                Rta = ex.Message;
                return null;
            }
        }*/
