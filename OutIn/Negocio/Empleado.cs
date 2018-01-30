﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OutInDB;

namespace Negocio
{
    public class Empleado:Respuesta
    {// controlador de los empleados
        OutInDBDataContext datos = new OutInDBDataContext();
        public  accederEmpleadoResult ingresar(string usu, string pass)
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
        public List<verEmpleadosResult> listarEmpleado()
        {// mostrar un listado de los empleados
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

        }
    }
}
