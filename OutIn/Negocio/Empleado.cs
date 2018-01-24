using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OutInDB;

namespace Negocio
{
    public class Empleado:Respuesta
    {
        OutInDBDataContext datos = new OutInDBDataContext();
        public  accederEmpleadoResult ingresar(string usu, string pass)
        {
            try
            {
                accederEmpleadoResult emp = datos.accederEmpleado(usu, pass).FirstOrDefault();
                Codigo = "OK";
                Rta = "Se ingreso el empleado correctamente";
                return emp;
            }
            catch (Exception ex)
            {
                Codigo = "Error";
                Rta = ex.Message;
                return null;
            }
        }
        public List<verEmpleadosResult> listarEmpleado()
        {
            try
            {
                List<verEmpleadosResult> lisEmpleado = datos.verEmpleados().ToList();
                Codigo = "OK";
                Rta = "Se realizo correctamente";
                return lisEmpleado;
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
