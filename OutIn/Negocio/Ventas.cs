using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OutInDB;

namespace Negocio
{
    public class Ventas : Movimiento
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
        //metodo para consultar el producto y cargarlo para venta
        public List<seleccionarproductoxcodResult> cargaProducto(int numero)
        {
            try
            {
                List<seleccionarproductoxcodResult> pd = datos.seleccionarproductoxcod(numero).ToList();
                Codigo = "OK";
                Rta = "Se realizo correctamente";
                return pd;
            }
            catch(Exception ex)
            {
                Codigo = "Error";
                Rta = ex.Message;
                return null;
            }
        }
        //se sobrecarga el metodo para poder ser buscado por nombre
        protected List<seleccionarproductoResult> cargaProducto (String nombre)
        {
            try
            {
                List<seleccionarproductoResult> pd = datos.seleccionarproducto(nombre).ToList();
                Codigo = "OK";
                Rta = "Se realizo correctamente";
                return pd;
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
