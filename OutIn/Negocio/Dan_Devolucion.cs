using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OutInDB;

namespace Negocio
{
    public class Dan_Devolucion
    {
        OutInDBDataContext db = new OutInDBDataContext();

        public void insertardanodev(DateTime fecha,int producto,int cantidad,string emple,string ubic,int tipo,string text )
        {
            db.InsertarDdevolucion(fecha,producto,cantidad,emple,ubic,tipo,text);
        }
    }


}
