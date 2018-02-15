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
        public List<string> guardar(string producto, string cant)
        {
            List<string> li = new List<string>();
            li.Add(producto);
            li.Add(cant);
            return li;
        }
        public List<string> guardar( List<string> l , string producto, string cant)
        {
            List<string> li = new List<string>();
            
            foreach (var item in l)
            {
                li.Add(item);
            }
            li.Add(producto);
            li.Add(cant);
            return li;
        }
    }


}
