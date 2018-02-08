using OutInDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class OrdenCompra : Movimiento
    {// controlador de los empleados
        OutInDBDataContext datos = new OutInDBDataContext();
        /*public accederEmpleadoResult ingresar(string usu, string pass)
        {// validar el ingreso de un empleado
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
        
        public bool registraEmpleado(string id, DateTime nacimiento, string nombre, string contrasena, string tipo, string direccion, string cargo, string contacto)
        {// registrar un empleado a la base de datos
            try
            {
                int ti = 0;
                int ca = 0;
                switch (tipo)
                {
                    case "C.C.":
                        ti = 1;
                        break;
                    case "C.E.":
                        ti = 4;
                        break;
                    default:
                        break;
                }
                switch (cargo)
                {
                    case "Administrador":
                        ca = 1;
                        break;
                    case "Cajero":
                        ca = 2;
                        break;
                    case "Almacenista":
                        ca = 3;
                        break;
                    default:
                        break;
                }
                datos.registrarEmpleado(id, nacimiento, nombre, contrasena, ti, direccion, ca, contacto);
                return true;
            }
            catch (Exception ex)
            {
                Rta = ex.Message;
                return false;
            }
        }
        public bool EliminarEmpleado(string id)
        {
            try
            {
                datos.eliminarEmpleado(id);
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

        }*/
        public List<listarOrdenCompraResult> listarOrdenCompra()
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
        }


        public bool registrarOc(DateTime moFecha,int moProducto ,int moCnat ,string moEmp,string moUbi ,int moTipo,decimal Prec )
        {// registrar un empleado a la base de datos
            try
            {

                datos.insertarOrdenCompra(moFecha, moProducto, moCnat, moEmp, moUbi, moTipo, Prec);
                return true;

            }
            catch (Exception ex)
            {
                Rta = ex.Message;
                return false;
            }
        }

    }
}

